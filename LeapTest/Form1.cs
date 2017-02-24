using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leap;
using System.Runtime.InteropServices;
using System.Threading;

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

        /// <summary>
        /// hier starten we met de handdetectie
        /// ook letters worden hier herkent
        /// Neel Borghs
        /// </summary>
        
        //Teller voor letters uit te lezen
        int i = 0;


        Random rnd = new Random();
        int intBeginner = 1;
        int intLetter = 0;
        int intScore = 0;
        int intDubbel = 0;
        int intTimer = 6;
        //Boolean dat bekijkt of hand is uitgelezen
        int intUitgelezen = 0;


        float oduim = 0;
        float owijsvinger = 0;
        float omiddelvinger = 0;
        float oringvinger = 0;
        float opink = 0;

        Boolean blnBeginner = false;
        Boolean blnExpert = false;


        string test = null;

        public void detectHandPosition(Leap.Frame frame)
        {
            HandList allHands = frame.Hands;
            foreach (Hand hand in allHands)
            {

                if (intUitgelezen == 1)
                {


                    for (int i = 0; i < hand.Fingers.Count; i++)
                    {
                        Finger finger = hand.Fingers[i];

                        string fingerName = finger.ToString();
                        Vector mcpPos = finger.JointPosition(Finger.FingerJoint.JOINT_MCP);
                        Vector tipPos = finger.JointPosition(Finger.FingerJoint.JOINT_TIP);
                        float angle = (float)(mcpPos.AngleTo(tipPos) * (180 / Math.PI));
                        Vector fingerPosition = finger.TipPosition;
                        float distance = hand.PalmPosition.DistanceTo(tipPos);


                        if (i == 0)
                        {
                            txtDuim.Text = distance.ToString();
                            oduim = distance;
                            txtDuim.Text = oduim.ToString();
                        }
                        if (i == 1)
                        {
                            txtWijsvinger.Text = distance.ToString();
                            owijsvinger = distance;
                            txtWijsvinger.Text = owijsvinger.ToString();
                        }
                        if (i == 2)
                        {
                            txtMiddelvinger.Text = distance.ToString();
                            omiddelvinger = distance;
                            txtMiddelvinger.Text = omiddelvinger.ToString();
                        }
                        if (i == 3)
                        {
                            txtRingvinger.Text = distance.ToString();
                            oringvinger = distance;
                            txtRingvinger.Text = oringvinger.ToString();
                        }
                        if (i == 4)
                        {
                            txtPink.Text = distance.ToString();
                            opink = distance;
                            txtPink.Text = opink.ToString();
                        }
                    }
                    intUitgelezen = 2;

                }

                if (intUitgelezen == 2)
                {
                    float duim = 0;
                    float wijsvinger = 0;
                    float middelvinger = 0;
                    float ringvinger = 0;
                    float pink = 0;

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
                    lblTekst.Text = " ";



                    for (int i = 0; i < hand.Fingers.Count; i++)
                    {
                        Finger finger = hand.Fingers[i];

                        string fingerName = finger.ToString();
                        Vector mcpPos = finger.JointPosition(Finger.FingerJoint.JOINT_MCP);
                        Vector tipPos = finger.JointPosition(Finger.FingerJoint.JOINT_TIP);
                        float angle = (float)(mcpPos.AngleTo(tipPos) * (180 / Math.PI));
                        Vector fingerPosition = finger.TipPosition;
                        float distance = hand.PalmPosition.DistanceTo(tipPos);


                        if (i == 0)
                        {
                            txtDuim.Text = distance.ToString();
                            duim = distance;
                        }
                        if (i == 1)
                        {
                            txtWijsvinger.Text = distance.ToString();
                            wijsvinger = distance;
                        }
                        if (i == 2)
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

                    //A//
                    if ((intRoll > -30) && (oduim - duim) < 10 && (owijsvinger - wijsvinger) > 15 && (omiddelvinger - middelvinger) > 15 && (oringvinger - ringvinger) > 15 && (opink - pink) > 15)
                    {


                        lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                        lblTekst.Text = "A";
                        intLetter = 1;

                    }
                    //B//
                    else if ((intRoll > -30) && (oduim - duim) > 10 && (owijsvinger - wijsvinger) < 15 && (omiddelvinger - middelvinger) < 15 && (oringvinger - ringvinger) < 15 && (opink - pink) < 15)
                    {


                        lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                        lblTekst.Text = "B";
                        intLetter = 2;

                    }
                    //D//
                    else if ((intRoll > -30) && (oduim - duim) > 10 && (owijsvinger - wijsvinger) < 15 && (omiddelvinger - middelvinger) > 15 && (oringvinger - ringvinger) > 15 && (opink - pink) > 15)
                    {


                        lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                        lblTekst.Text = "D";
                        intLetter = 3;

                    }
                    //E//
                    else if ((intRoll > -30) && (oduim - duim) > 10 && (owijsvinger - wijsvinger) > 15 && (omiddelvinger - middelvinger) > 15 && (oringvinger - ringvinger) > 15 && (opink - pink) > 15)
                    {


                        lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                        lblTekst.Text = "E";
                        intLetter = 4;

                    }
                    //F//
                    else if ((intRoll > -30) && (oduim - duim) > 10 && (owijsvinger - wijsvinger) > 15 && (omiddelvinger - middelvinger) < 15 && (oringvinger - ringvinger) < 15 && (opink - pink) < 15)
                    {


                        lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                        lblTekst.Text = "F";
                        intLetter = 5;

                    }


                    //H//
                    else if ((intRoll < -60) && (oduim - duim) < 10 && (owijsvinger - wijsvinger) < 15 && (omiddelvinger - middelvinger) < 15 && (oringvinger - ringvinger) > 15 && (opink - pink) > 15)
                    {


                        lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                        lblTekst.Text = "H";
                        intLetter = 6;

                    }


                    //I//
                    else if ((intRoll > -30) && (oduim - duim) > 10 && (owijsvinger - wijsvinger) > 15 && (omiddelvinger - middelvinger) > 15 && (oringvinger - ringvinger) > 15 && (opink - pink) < 15)
                    {

                        lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                        lblTekst.Text = ("I");
                        intLetter = 7;

                    }
                    //K//
                    else if ((intRoll > -30) && (oduim - duim) > 10 && (owijsvinger - wijsvinger) < 15 && (omiddelvinger - middelvinger) < 15 && (oringvinger - ringvinger) > 15 && (opink - pink) > 15)
                    {


                        lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                        lblTekst.Text = "K";
                        intLetter = 8;

                    }
                    //L//
                    else if ((intRoll > -30) && (oduim - duim) < 10 && (owijsvinger - wijsvinger) < 15 && (omiddelvinger - middelvinger) > 15 && (oringvinger - ringvinger) > 15 && (opink - pink) > 15)
                    {
                        lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                        lblTekst.Text = "L";
                        intLetter = 9;

                    }
                    //W//
                    else if ((intRoll > -30) && (oduim - duim) > 10 && (owijsvinger - wijsvinger) < 15 && (omiddelvinger - middelvinger) < 15 && (oringvinger - ringvinger) < 15 && (opink - pink) > 15)
                    {


                        lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                        lblTekst.Text = "W";
                        intLetter = 10;

                    }
                    //Y//
                    else if ((intRoll > -30) && (oduim - duim) < 10 && (owijsvinger - wijsvinger) > 15 && (omiddelvinger - middelvinger) > 15 && (oringvinger - ringvinger) > 15 && (opink - pink) < 15)
                    {


                        lblTekst.Font = new Font(lblTekst.Font.FontFamily, 150);
                        lblTekst.Text = "Y";
                        intLetter = 11;

                    }




                    txtRoll.Text = intRoll.ToString();

                    if (blnBeginner == true)
                    {
                        pctGebaren.Visible = true;
                        lblBeginnerVoorbeeld.Visible = true;
                        switch (intBeginner)
                        {
                            case 1:
                                pctGebaren.Image = Properties.Resources._1;
                                lblOefenLetter.Text = "A";
                                break;
                            case 2:
                                pctGebaren.Image = Properties.Resources._2;
                                lblOefenLetter.Text = "B";
                                break;
                            case 3:
                                pctGebaren.Image = Properties.Resources._3;
                                lblOefenLetter.Text = "D";
                                break;
                            case 4:
                                pctGebaren.Image = Properties.Resources._4;
                                lblOefenLetter.Text = "E";
                                break;
                            case 5:
                                pctGebaren.Image = Properties.Resources._5;
                                lblOefenLetter.Text = "F";
                                break;
                            case 6:
                                pctGebaren.Image = Properties.Resources._6;
                                lblOefenLetter.Text = "H";
                                break;
                            case 7:
                                pctGebaren.Image = Properties.Resources._7;
                                lblOefenLetter.Text = "I";
                                break;
                            case 8:
                                pctGebaren.Image = Properties.Resources._8;
                                lblOefenLetter.Text = "K";
                                break;
                            case 9:
                                pctGebaren.Image = Properties.Resources._9;
                                lblOefenLetter.Text = "L";
                                break;
                            case 10:
                                pctGebaren.Image = Properties.Resources._10;
                                lblOefenLetter.Text = "W";
                                break;
                            case 11:
                                pctGebaren.Image = Properties.Resources._11;

                                lblOefenLetter.Text = "Y";
                                break;
                        }
                    }
                    else if (blnExpert == true)
                    {
                        pctGebaren.Visible = false;
                        switch (intBeginner)
                        {
                            case 1:
                                pctGebaren.Image = Properties.Resources._1;
                                lblOefenLetter.Text = "A";
                                break;
                            case 2:
                                pctGebaren.Image = Properties.Resources._2;
                                lblOefenLetter.Text = "B";
                                break;
                            case 3:
                                pctGebaren.Image = Properties.Resources._3;
                                lblOefenLetter.Text = "D";
                                break;
                            case 4:
                                pctGebaren.Image = Properties.Resources._4;
                                lblOefenLetter.Text = "E";
                                break;
                            case 5:
                                pctGebaren.Image = Properties.Resources._5;
                                lblOefenLetter.Text = "F";
                                break;
                            case 6:
                                pctGebaren.Image = Properties.Resources._6;
                                lblOefenLetter.Text = "H";
                                break;
                            case 7:
                                pctGebaren.Image = Properties.Resources._7;
                                lblOefenLetter.Text = "I";
                                break;
                            case 8:
                                pctGebaren.Image = Properties.Resources._8;
                                lblOefenLetter.Text = "K";
                                break;
                            case 9:
                                pctGebaren.Image = Properties.Resources._9;
                                lblOefenLetter.Text = "L";
                                break;
                            case 10:
                                pctGebaren.Image = Properties.Resources._10;
                                lblOefenLetter.Text = "W";
                                break;
                            case 11:
                                pctGebaren.Image = Properties.Resources._11;
                                lblOefenLetter.Text = "Y";
                                break;
                        }
                    }


                    /// <summary>
                    /// Kijken of letter overeenkomt met de nodige letter
                    /// nieuwe random letter kiezen
                    /// kijken of random letter dezelfde is als vorige keer
                    /// Zoja? Letter veranderen naar een letter die vlak hiervoor niet is voorgekomen
                    /// Zonee? Pak deze random letter
                    /// </summary>

                    txtTekst.Text += lblTekst.Text;

                    intDubbel = intBeginner;

                    if (blnBeginner)
                    {
                        if (intBeginner == intLetter)
                        {
                            if (i > 200)
                            {
                                if (txtTekst.Text.Substring(i, 1) == txtTekst.Text.Substring(i - 199, 1))
                                {


                                    txtResultaat.Text += txtTekst.Text.Substring(i, 1);

                                    txtResultaat.Text += txtTekst.Text.Substring(i, 1);
                                    intBeginner = rnd.Next(11);
                                    intScore += 1;
                                    lblScore.Text = intScore.ToString();
                                    lblScore.Visible = true;
                                    lblScoreTekst.Visible = true;
                                    intDubbel = intBeginner;

                                    if (blnBeginner)
                                    {
                                        pctJuist.Visible = true;


                                    }





                                    if (intBeginner == intDubbel)
                                    {
                                        intBeginner += 1;
                                        if (intBeginner > 11)
                                        {
                                            intBeginner = 1;
                                        }
                                    }


                                }
                                else
                                {
                                    pctJuist.Visible = false;
                                }
                            }



                        }
                    }
                    if (blnExpert)
                    {
                        if (intBeginner == intLetter)
                        {

                            txtResultaat.Text += txtTekst.Text.Substring(i, 1);
                            intBeginner = rnd.Next(11);
                            intScore += 1;
                            lblScore.Text = intScore.ToString();
                            lblScore.Visible = true;
                            lblScoreTekst.Visible = true;
                            intDubbel = intBeginner;

                            if (blnBeginner)
                            {
                                pctJuist.Visible = true;

                                pctJuist.Visible = false;
                            }





                            if (intBeginner == intDubbel)
                            {
                                intBeginner += 1;
                                if (intBeginner > 11)
                                {
                                    intBeginner = 1;
                                }
                            }


                        }
                    }
                    


                    i += 1;


                }
            }

               
        }

        //Geen blinkende cursor tonen in actieve textbox
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        private void txtResultaat_TextChanged(object sender, EventArgs e)
        {
            HideCaret(txtResultaat.Handle);
        }

        private void btnBeginner_Click(object sender, EventArgs e)
        {
            blnBeginner = true;
            blnExpert = false;
            btnExpert.Visible = false;
            btnBeginner.Visible = false;
        }

        private void btnExpert_Click(object sender, EventArgs e)
        {
            blnExpert = true;
            blnBeginner = false;
            btnExpert.Visible = false;
            btnBeginner.Visible = false;
        }

        private void tmrUitlezen_Tick(object sender, EventArgs e)
        {
            if (intTimer == 0)
            {
                intUitgelezen = 1;
                lblTimer.Visible = false;
                lblInfoTimer.Visible = false;
                pctHand.Visible = false;
                tmrUitlezen.Stop();
                detectHandPosition(controller.Frame());
                btnBeginner.Visible = true;
                btnExpert.Visible = true;


            }
            else
            {
                intTimer -= 1;
                lblTimer.Text = intTimer.ToString();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrUitlezen.Start();
        }

        private void tmrJuist_Tick(object sender, EventArgs e)
        {

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
