using UiPath.Mail;
using Microsoft.Graph;
using UiPath.Core.Activities;
using REFrameworkCommonTemplatev0._03.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Mail.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using System.Net;
using System.Net.Mail;
using Tesseract; 
using System.Drawing; // For image processing if needed

namespace REFrameworkCommonTemplatev0._03
{
    public class Workflow : CodedWorkflow
    {
        [Workflow]
        public void Execute()
        {


// Input parameters (you can pass them from UiPath arguments/variables)
string fromAddress = "dthilakarathne@innobothealth.com";
string toAddress = "dthilakarathne@innobothealth.com";
string subject = "Hey Sexy What's up";
string body = "Hello! This is Your WTF Bot.";

// SMTP Configuration
string smtpHost = "smtp.office365.com";   // Example: Gmail: smtp.gmail.com, Outlook: smtp.office365.com
int smtpPort = 587;
string username = "dthilarathne@innobothealth.com";
string password = "!@#09235";  //

// Create and send the message
var smtp = new SmtpClient(smtpHost, smtpPort)
{
    Credentials = new NetworkCredential(username, password),
    EnableSsl = true
    PasswordCredential = true
    New password = new NetworkConnection (username, password)
    

};

MailMessage message = new MailMessage(fromAddress, toAddress, subject, body);
smtp.Send(message);
    String subject = "2nd Try Email . . . . "
MailMessageExtensions new Message = new MailAddressCollection (from, toAdd, subj, body);


            List<int> inputNumbers = new List<int>() { 40, 50, 100, 80, 60, 90 }; // This would typically be an 'In' argument

        }
    }
}

public class PdfOcrProcessor
{
    public string ExtractTextFromPdf(string pdfFilePath)
    {
        string extractedText = "";
        try
        {
            // Convert PDF pages to images (requires a PDF rendering library like PdfiumViewer or similar)
            // For simplicity, let's assume you have an image file already
            using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            {
                using (var img = Pix.LoadFromFile("engine")) 
                {
                    using (var page = engine.Process(img))
                    {
                        extractedText = page.GetText();
                        Console.WriteLine("OCR Try Block $: {ex.Message}");
                        extractedText = page.GetText(0);
                        Console.WriteLine(page,"$: Console Page passed");
                        
                    }
                }
            }
        }
        catch (TesseractException ex)
        {
            Console.WriteLine($"Error during OCR: {ex.Message}");
            Console.WriteLine("OCR Exception OCR: {ex.Message}");
            
        }
        return extractedText;
    }
}