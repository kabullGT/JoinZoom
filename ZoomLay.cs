using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZOOM_SDK_DOTNET_WRAP;

namespace JoinZoom
{
    public partial class ZoomLay : Form
    {
        public ZoomLay()
        {
            InitializeComponent();
            pboxOverlayWait.BringToFront();
            if(Util.meetingId.Length > 0)
            {
                txtMeetingId.Text = Util.meetingId;
            }
            else
            {
                txtUiMessages.ForeColor = Color.Red;
                txtUiMessages.Text = "Meeting ID invalid!";
            }
            if (Util.userName.Length > 0)
            {
                txtUserName.Text = Util.userName;
            }

            if (Util.password.Length > 0)
            {
                txtPwd.Text = Util.password;
            }

            RegisterCallBack();
            AuthZoomSDK();

        }


        private static void AuthZoomSDK()
        {
            //
            ZOOM_SDK_DOTNET_WRAP.AuthContext param = new ZOOM_SDK_DOTNET_WRAP.AuthContext();
            param.jwt_token = Util.zoomJWT;
            ZOOM_SDK_DOTNET_WRAP.SDKError err = ZOOM_SDK_DOTNET_WRAP.CZoomSDKeDotNetWrap.Instance.GetAuthServiceWrap().SDKAuth(param);
            //Hide();
        }

        //callback
        public void onAuthenticationReturn(AuthResult ret)
        {
            if (ZOOM_SDK_DOTNET_WRAP.AuthResult.AUTHRET_SUCCESS == ret)
            {
#if _DEBUG_BOX_MSG
                MessageBox.Show("AUTHRET_SUCCESS !");
#endif
                this.pboxOverlayWait.SendToBack();
                btnJoinMeeting_Click(this, null);
            }
            else//error handle.todo
            {
#if DEBUG_BOX_MSG
                MessageBox.Show("AUTHRET_ERROR !!!!!!!!!!!!!!");
#endif
            }
        }
        public static void onLoginRet(LOGINSTATUS ret, IAccountInfo pAccountInfo)
        {
            //todo
        }
        public static void onLogout()
        {
            //todo
        }


        private void Application_Exit()//(object sender, ExitEventArgs e)
        {
            //clean up sdk
            ZOOM_SDK_DOTNET_WRAP.CZoomSDKeDotNetWrap.Instance.CleanUp();
        }

        //ZOOM_SDK_DOTNET_WRAP.onMeetingStatusChanged
        public void onMeetingStatusChanged(MeetingStatus status, int iResult)
        {
            switch (status)
            {
                case ZOOM_SDK_DOTNET_WRAP.MeetingStatus.MEETING_STATUS_ENDED:
//                    {
//#if DEBUG_BOX_MSG
//                        MessageBox.Show("TODO: Beautifull finish !!");
//#endif
//                        System.Console.Beep(1500, 1000);
//                        Show();
//                    }
                    break;
                case ZOOM_SDK_DOTNET_WRAP.MeetingStatus.MEETING_STATUS_FAILED:
                    {
                        System.Console.Beep(1500, 300);
#if DEBUG_BOX_MSG
                        MessageBox.Show("Fail to connect to meeting #: "+ Util.meetingId);
#endif
                        Show();
                    }
                    break;
                default://todo
                    break;
            }
        }

        public void onUserJoin(Array lstUserID)
        {

#if _DEBUG_BOX_MSG
            MessageBox.Show("onUserJoin");
#endif
            if (null == (Object)lstUserID)
                return;
            //This gives a list of users in the meeting
            for (int i = lstUserID.GetLowerBound(0); i <= lstUserID.GetUpperBound(0); i++)
            {
                UInt32 userid = (UInt32)lstUserID.GetValue(i);
                ZOOM_SDK_DOTNET_WRAP.IUserInfoDotNetWrap user = ZOOM_SDK_DOTNET_WRAP.CZoomSDKeDotNetWrap.Instance.GetMeetingServiceWrap().
                    GetMeetingParticipantsController().GetUserByUserID(userid);
                if (null != (Object)user)
                {
                    string name = user.GetUserNameW();
                    Console.Write(name);
#if _DEBUG_BOX_MSG
                    MessageBox.Show("onUserJoin" + name);
#endif
                }
            }
        }
        public void onUserLeft(Array lstUserID)
        {
            //todo
#if DEBUG_BOX_MSG
                    MessageBox.Show("onUserLeft: " + lstUserID);
#endif
        }
        public void onHostChangeNotification(UInt32 userId)
        {
            //todo
        }
        public void onLowOrRaiseHandStatusChanged(bool bLow, UInt32 userid)
        {
            //todo
        }
        public void onUserNameChanged(UInt32 userId, string userName)
        {
            //todo
        }
        private void RegisterCallBack()
        {
            ZOOM_SDK_DOTNET_WRAP.CZoomSDKeDotNetWrap.Instance.GetMeetingServiceWrap().Add_CB_onMeetingStatusChanged(onMeetingStatusChanged);
            ZOOM_SDK_DOTNET_WRAP.CZoomSDKeDotNetWrap.Instance.GetMeetingServiceWrap().
                GetMeetingParticipantsController().Add_CB_onHostChangeNotification(onHostChangeNotification);
            ZOOM_SDK_DOTNET_WRAP.CZoomSDKeDotNetWrap.Instance.GetMeetingServiceWrap().
                GetMeetingParticipantsController().Add_CB_onLowOrRaiseHandStatusChanged(onLowOrRaiseHandStatusChanged);
            ZOOM_SDK_DOTNET_WRAP.CZoomSDKeDotNetWrap.Instance.GetMeetingServiceWrap().
                GetMeetingParticipantsController().Add_CB_onUserJoin(onUserJoin);
            ZOOM_SDK_DOTNET_WRAP.CZoomSDKeDotNetWrap.Instance.GetMeetingServiceWrap().
                GetMeetingParticipantsController().Add_CB_onUserLeft(onUserLeft);
            ZOOM_SDK_DOTNET_WRAP.CZoomSDKeDotNetWrap.Instance.GetMeetingServiceWrap().
                GetMeetingParticipantsController().Add_CB_onUserNameChanged(onUserNameChanged);

            //register callback
            ZOOM_SDK_DOTNET_WRAP.CZoomSDKeDotNetWrap.Instance.GetAuthServiceWrap().Add_CB_onAuthenticationReturn(onAuthenticationReturn);
            ZOOM_SDK_DOTNET_WRAP.CZoomSDKeDotNetWrap.Instance.GetAuthServiceWrap().Add_CB_onLoginRet(onLoginRet);
            ZOOM_SDK_DOTNET_WRAP.CZoomSDKeDotNetWrap.Instance.GetAuthServiceWrap().Add_CB_onLogout(onLogout);
        }
        //private void button_start_api_Click()
        //{
        //    RegisterCallBack();
        //    ZOOM_SDK_DOTNET_WRAP.StartParam param = new ZOOM_SDK_DOTNET_WRAP.StartParam();
        //    param.userType = ZOOM_SDK_DOTNET_WRAP.SDKUserType.SDK_UT_WITHOUT_LOGIN;
        //    ZOOM_SDK_DOTNET_WRAP.StartParam4WithoutLogin start_withoutlogin_param = new ZOOM_SDK_DOTNET_WRAP.StartParam4WithoutLogin();
        //    start_withoutlogin_param.meetingNumber = UInt64.Parse(textBox_meetingnumber_api.Text);
        //    start_withoutlogin_param.userID = textBox_userid_api.Text;
        //    start_withoutlogin_param.userZAK = textBox_AccessToken.Text;
        //    start_withoutlogin_param.userName = textBox_username_api.Text;
        //    start_withoutlogin_param.zoomuserType = ZOOM_SDK_DOTNET_WRAP.ZoomUserType.ZoomUserType_APIUSER;
        //    param.withoutloginStart = start_withoutlogin_param;

        //    ZOOM_SDK_DOTNET_WRAP.SDKError err = ZOOM_SDK_DOTNET_WRAP.CZoomSDKeDotNetWrap.Instance.GetMeetingServiceWrap().Start(param);
        //    if (ZOOM_SDK_DOTNET_WRAP.SDKError.SDKERR_SUCCESS == err)
        //    {
        //        Hide();
        //    }
        //    else//error handle
        //    { }

        //}

        private void btnJoinMeeting_Click(object sender, EventArgs e)
        {
            Util.meetingId = txtMeetingId.Text;
            Util.userName = txtUserName.Text;
            Util.password = txtPwd.Text;
            //Settings
            ZOOM_SDK_DOTNET_WRAP.CZoomSDKeDotNetWrap.Instance.GetSettingServiceWrap().GetAudioSettings().EnableAutoJoinAudio(true);
            ZOOM_SDK_DOTNET_WRAP.CZoomSDKeDotNetWrap.Instance.GetSettingServiceWrap().GetGeneralSettings().EnableAutoFullScreenVideoWhenJoinMeeting(true);     
            //ZOOM_SDK_DOTNET_WRAP.CZoomSDKeDotNetWrap.Instance.GetSettingServiceWrap().GetVideoSettings().EnableAutoTurnOffVideoWhenJoinMeeting(false);

            ZOOM_SDK_DOTNET_WRAP.JoinParam param = new ZOOM_SDK_DOTNET_WRAP.JoinParam();
            param.userType = ZOOM_SDK_DOTNET_WRAP.SDKUserType.SDK_UT_WITHOUT_LOGIN;
            ZOOM_SDK_DOTNET_WRAP.JoinParam4WithoutLogin join_api_param = new ZOOM_SDK_DOTNET_WRAP.JoinParam4WithoutLogin();
            join_api_param.meetingNumber = UInt64.Parse(Util.meetingId);//UInt64.Parse(textBox_meetingnumber_api.Text);
            join_api_param.userName = Util.userName;// textBox_username_api.Text;
            join_api_param.psw = Util.password;
            param.withoutloginJoin = join_api_param;

            ZOOM_SDK_DOTNET_WRAP.SDKError err = ZOOM_SDK_DOTNET_WRAP.CZoomSDKeDotNetWrap.Instance.GetMeetingServiceWrap().Join(param);
            if (ZOOM_SDK_DOTNET_WRAP.SDKError.SDKERR_SUCCESS == err)
            {
                Hide();
            }
            else//error handle
            {
#if DEBUG_BOX_MSG
                    MessageBox.Show("onUserJoin Error: Fail to Join\n" + err);
#endif
            }
        }

        private void btnExitMeeting_Click(object sender, EventArgs e)
        {
            //clean up sdk
            ZOOM_SDK_DOTNET_WRAP.CZoomSDKeDotNetWrap.Instance.CleanUp();
            this.Close();
        }
    }
}
