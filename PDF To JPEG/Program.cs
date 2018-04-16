//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using System;

using Bytescout.PDFRenderer;


namespace PDF2JPEG
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it
			RasterRenderer renderer = new RasterRenderer();
			renderer.RegistrationName = "demo";
			renderer.RegistrationKey = "demo";

			// Load PDF document
			renderer.LoadDocumentFromFile("multipage.pdf");

			for (int i = 0; i < renderer.GetPageCount(); i++)
			{
                // Render document page to PNG image file.
				renderer.Save("image" + i + ".jpg", RasterImageFormat.JPEG, i, 96);
			}

			// Open the first output file in default image viewer.
			System.Diagnostics.Process.Start("image0.jpg");
		}
	}
}
