﻿using System;

using System.Net;

using System.Net.Mail;



namespace EmailSmtp

{

    class Program

    {

        static void Main(string[] args)

        {

            try

            {

                // Credentials

                var credentials = new NetworkCredential("towplus79@gmail.com", "");



                // Mail message

                var mail = new MailMessage()

                {

                    From = new MailAddress("towplus79@gmail.com"),

                    Subject = "Test email.",

                    Body = "Test email body"

                };



                mail.To.Add(new MailAddress("freshpig79@gmail.com"));



                // Smtp client

                var client = new SmtpClient()

                {

                    Port = 587,

                    DeliveryMethod = SmtpDeliveryMethod.Network,

                    UseDefaultCredentials = false,

                    Host = "smtp.gmail.com",

                    EnableSsl = true,

                    Credentials = credentials

                };



                // Send it...         

                client.Send(mail);

            }

            catch (Exception ex)

            {

                Console.WriteLine("Error in sending email: " + ex.Message);

                Console.ReadKey();

                return;

            }



            Console.WriteLine("Email sccessfully sent");

            Console.ReadKey();

        }

    }

}