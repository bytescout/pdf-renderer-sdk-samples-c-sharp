//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using System;

using Bytescout.PDFRenderer;


namespace PDF2PNG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
            RasterRenderer renderer = new RasterRenderer();
            renderer.RegistrationName = "demo";
            renderer.RegistrationKey = "demo";

            // Set high quality resolution 600 dpi (600 dots per inch)
            float renderingResolution = 600;

            // Load PDF document.
            renderer.LoadDocumentFromFile("multipage.pdf");

            for (int i = 0; i < renderer.GetPageCount(); i++)
            {
                // Render first page of the document to PNG image file.
                renderer.Save("image" + i + ".png", RasterImageFormat.PNG, i, renderingResolution);
            }

            // Cleanup
            renderer.Dispose();

            // Open the first output file in default image viewer.
            System.Diagnostics.Process.Start("image0.png");
        }
    }
}
