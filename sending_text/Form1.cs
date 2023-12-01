using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace sending_text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Your Twilio Account SID and Auth Token
            const string accountSid = "your_account_sid";
            const string authToken = "your_auth_token";

            // Initialize the Twilio client
            TwilioClient.Init(accountSid, authToken);

            // Send an SMS message
            var message = MessageResource.Create(
                body: "Hello, this is a test message!",
                from: new Twilio.Types.PhoneNumber("your_twilio_phone_number"),
                to: new Twilio.Types.PhoneNumber("recipient_phone_number")
            );

            Console.WriteLine($"SMS sent with SID: {message.Sid}");

        }
    }
}
