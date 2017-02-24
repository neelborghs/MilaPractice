using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Leap;

namespace LeapTest
{
    public partial class Form1 : Form, ILeapEventDelegate
    {
        private Controller controller;
        private LeapEventListener listener;

        public Form1()
        {
            InitializeComponent();

            this.controller = new Controller();
            this.listener = new LeapEventListener(this);
            controller.AddListener(listener);
        }

        delegate void LeapEventDelegate(string EventName);
        public void LeapEventNotification(string EventName)
        {
            if (!this.InvokeRequired)
            {
                switch (EventName)
                {
                    case "onInit":
                        
                        break;
                    case "onConnect":
                        connectHandler();
                        break;
                    case "onFrame":
                        detectGesture(this.controller.Frame());
                        detectHandPosition(this.controller.Frame());
                        break;
                }
            }
            else
            {
                BeginInvoke(new LeapEventDelegate(LeapEventNotification), new object[] { EventName });
            }
        }

        public void connectHandler()
        {
            //enable all the gestures
            this.controller.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
            this.controller.EnableGesture(Gesture.GestureType.TYPE_KEY_TAP);
            this.controller.EnableGesture(Gesture.GestureType.TYPE_SWIPE);
            this.controller.EnableGesture(Gesture.GestureType.TYPE_SCREEN_TAP);
        }

        public void detectGesture(Leap.Frame frame)
        {
            GestureList gestures = frame.Gestures(); //returns list of gestures

            for(int i=0; i<gestures.Count(); i++)
            {
                Gesture gesture = gestures[i];

                switch (gesture.Type)
                {
                    case Gesture.GestureType.TYPE_CIRCLE:
                        richTextBox1.AppendText("Circle detected!" + Environment.NewLine);
                        break;
                    case Gesture.GestureType.TYPE_SCREEN_TAP:
                        richTextBox1.AppendText("Screen tap detected!" + Environment.NewLine);
                        break;
                    case Gesture.GestureType.TYPE_KEY_TAP:
                        richTextBox1.AppendText("Key tap detected!" + Environment.NewLine);
                        break;
                    case Gesture.GestureType.TYPE_SWIPE:
                        richTextBox1.AppendText("Swipe detected!" + Environment.NewLine);
                        break;
                }
            }
        }

        public void detectHandPosition(Leap.Frame frame)
        {
            HandList allHands = frame.Hands;
            foreach (Hand hand in allHands)
            {
                float oduim = 80;
                float owijsvinger = 110;
                float omiddelvinger = 115;
                float oringvinger = 107;
                float opink = 94;
                float duim = 0;
                float wijsvinger = 0;
                float middelvinger = 0;
                float ringvinger = 0;
                float pink = 0;
                float oroll = 0;
                float pitch = hand.Direction.Pitch;
                float yaw = hand.Direction.Yaw;
                float roll = hand.PalmNormal.Roll;

                double degPitch = pitch * (180 / Math.PI); //convert to degree
                double degYaw = yaw * (180 / Math.PI);
                double degRoll = roll * (180 / Math.PI);

                int intPitch = (int)degPitch;
                int intYaw = (int)degYaw;
                int intRoll = (int)degRoll;

                txtDuim.Text = "een";

                for (int i = 0; i < hand.Fingers.Count; i++)
                {
                    Finger finger = hand.Fingers[i];

                    string fingerName = finger.ToString();
                    Vector mcpPos = finger.JointPosition(Finger.FingerJoint.JOINT_MCP);
                    Vector tipPos = finger.JointPosition(Finger.FingerJoint.JOINT_TIP);
                    float angle = (float)(mcpPos.AngleTo(tipPos) * (180 / Math.PI));
                    Vector fingerPosition = finger.TipPosition;
                    float distance = hand.PalmPosition.DistanceTo(tipPos);
                    

                    if (i==0)
                    {
                        txtDuim.Text = distance.ToString();
                        duim = distance;
                        Vector vctDuim = finger.JointPosition(Finger.FingerJoint.JOINT_TIP);
                    }
                    if (i==1)
                    {
                        txtWijsvinger.Text = distance.ToString();
                        wijsvinger = distance;
                        Vector vctWijsvinger = finger.JointPosition(Finger.FingerJoint.JOINT_TIP);
                    }
                    if (i==2)
                    {
                        txtMiddelvinger.Text = distance.ToString();
                        middelvinger = distance;
                    }
                    if (i == 3)
                    {
                        txtRingvinger.Text = distance.ToString();
                        ringvinger = distance;
                    }
                    if (i == 4)
                    {
                        txtPink.Text = distance.ToString();
                        pink = distance;
                    }
                    
                }

                //*//
                //*//
                
                //A//
                if ((intRoll > -65) && (oduim - duim) < 15 && (owijsvinger - wijsvinger) > 15 && (omiddelvinger - middelvinger) > 15 && (oringvinger - ringvinger)>15 && (opink-pink)>15)
                {
                    lblPintjes.Visible = false;
                    lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                    lblTekst.Text = ("A");
                }
                //L//
                else if ((intRoll > -65) && (oduim - duim) < 15 && (owijsvinger - wijsvinger) < 15 && (omiddelvinger - middelvinger) > 15 && (oringvinger - ringvinger) > 15 && (opink - pink) > 15)
                {
                    lblPintjes.Visible = false;
                    lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                    lblTekst.Text = ("L");
                }
                //H//
                else if ((intRoll < -65) && (owijsvinger - wijsvinger) < 15 && (omiddelvinger - middelvinger) < 15)
                {
                    lblPintjes.Visible = false;
                    lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                    lblTekst.Text = ("H");
                }
                //B//
                else if ((intRoll > -65) && (oduim - duim) > 15 && (owijsvinger - wijsvinger) < 15 && (omiddelvinger - middelvinger) < 15 && (oringvinger - ringvinger) < 15 && (opink - pink) < 15)
                {
                    lblPintjes.Visible = false;
                    lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                    lblTekst.Text = ("B");
                }
                
                //I//
                else if ((intRoll > -65) && (oduim - duim) > 15 && (owijsvinger - wijsvinger) > 15 && (omiddelvinger - middelvinger) > 15 && (oringvinger - ringvinger) > 15 && (opink - pink) < 15)
                {
                    lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                    lblTekst.Text = ("I");
                }
                //Love you//
                else if ((intRoll > -65) && (oduim - duim) < 15 && (owijsvinger - wijsvinger) < 15 && (omiddelvinger - middelvinger) > 15 && (oringvinger - ringvinger) > 15 && (opink - pink) < 15)
                {
                    lblPintjes.Visible = false;
                    lblTekst.Font = new Font(lblTekst.Font.FontFamily, 50);
                    lblTekst.Text = "Love you";
                }
                //E//
                
                else if ((intRoll > -65) && (oduim - duim) > 15 && (owijsvinger - wijsvinger) > 15 && (omiddelvinger - middelvinger) > 15 && (oringvinger - ringvinger) > 15 && (opink - pink) > 15)
                {
                    lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                    lblTekst.Text = ("E");
                }
                //K//

                else if ((intRoll > -65) && (oduim - duim) > 15 && (owijsvinger - wijsvinger) < 15 && (omiddelvinger - middelvinger) < 15 && (oringvinger - ringvinger) > 15 && (opink - pink) > 15)
                {
                    lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                    lblTekst.Text = ("K");
                }
                //F//
                else if ((intRoll > -65) && (oduim - duim) > 15 && (owijsvinger - wijsvinger) > 15 && (omiddelvinger - middelvinger) < 15 && (oringvinger - ringvinger) < 15 && (opink - pink) < 15)
                {
                    lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                    lblTekst.Text = ("F");
                }

                //High Five//
                else if ((intRoll > -65) && (oduim - duim) < 15 && (owijsvinger - wijsvinger) < 15 && (omiddelvinger - middelvinger) < 15 && (oringvinger - ringvinger) < 15 && (opink - pink) < 15)
                {
                    lblPintjes.Visible = false;
                    lblTekst.Font = new Font(lblTekst.Font.FontFamily, 80);
                    lblTekst.Text = ("High five");
                }
                //Y//
                else if ((intRoll > -65) && (oduim - duim) < 15 && (owijsvinger - wijsvinger) > 15 && (omiddelvinger - middelvinger) > 15 && (oringvinger - ringvinger) > 15 && (opink - pink) < 15)
                {
                    lblPintjes.Visible = false;
                    lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                    lblTekst.Text = ("Y");
                }
                //D//

                else if ((intRoll > -65) && (oduim - duim) > 15 && (owijsvinger - wijsvinger) < 15 && (omiddelvinger - middelvinger) > 15 && (oringvinger - ringvinger) > 15 && (opink - pink) > 15)
                {
                    lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                    lblTekst.Text = ("D");
                }

                float grab = hand.GrabStrength;

                txtPitch.Text = intPitch.ToString();
                txtYaw.Text = intYaw.ToString();
                txtRoll.Text = intRoll.ToString();

                txtGrab.Text = grab.ToString();

                //
                //

            }
        }


    }

    public interface ILeapEventDelegate
    {
        void LeapEventNotification(string EventName);
    }

    public class LeapEventListener : Listener
    {
        ILeapEventDelegate eventDelegate;

        public LeapEventListener(ILeapEventDelegate delegateObject)
        {
            this.eventDelegate = delegateObject;
        }
        public override void OnInit(Controller controller)
        {
            this.eventDelegate.LeapEventNotification("onInit");
        }
        public override void OnConnect(Controller controller)
        {
            this.eventDelegate.LeapEventNotification("onConnect");
        }
        public override void OnFrame(Controller controller)
        {
            this.eventDelegate.LeapEventNotification("onFrame");
        }
        public override void OnExit(Controller controller)
        {
            this.eventDelegate.LeapEventNotification("onExit");
        }
        public override void OnDisconnect(Controller controller)
        {
            this.eventDelegate.LeapEventNotification("onDisconnect");
        }
    }
}
