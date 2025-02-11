using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        
        string title = "CONSEJOS para conseguir tu PRIMER TRABAJO en IT - con Mara Schmitman";
        string author = "Pelado Nerd";
        int lenghtVideo = 2708;
            string commentName1= "@maraschmitman9613";
            string commentText1="Gracias por esta charla! Me sentí muy cómoda <3";
            string commentName2="@naahuu2011";
            string commentText2="27:27 primero me fijo en una base de mujeres y después al final de hombres cis y después la arreglo con si el cliente quiere KJJJJJ mamadera)";
            string commentName3="@JorgeLTSM";
            string commentText3="Esta es una cátedra entre dos expertos, el Pelado da muy buenas preguntas y Mara da muy buenos consejos, esta entrevista debería de ser Canasta Básica, de esos videos que si o si tienes que ver.";

        string title1 = "Build Applications with Bedrock and Lambda";
        string author1 = "FooBar Serverless";
        int lenghtVideo1 = 1005;
            string commentName4= "@DanielWeikert";
            string commentText4= "what about pricing. Is it competitive. How much do you pay for creating a few images and generate text?";
            string commentName5= "@RedCloudServices";
            string commentText5= "😊 I have it now in us-east-1 and with a single PDF it’s not great so far. it only offers titan embedding and another two via sagemaker. Does the LLM get better with different embedding models?";

            string commentName6= "@levelupai";
            string commentText6= "Grateful for the insights shared in this video, it's a gem! Subscribed for more🌟";

        string title2 = "🆕 Step Functions versions and alias!";
        string author2 = "FooBar Serverless";
        int lenghtVideo2 = 915;
            string commentName7= "@JoeAcosta-iy8lg";
            string commentText7= "Another great presentation Marcia!  Gracias!";
            string commentName8= "@dardosebastiangallay5770";
            string commentText8= "Saludos Marcia ! \nQuería agradecerte por tus  contenidos sobre  AWS . Gracias a tu claridad y pasión, he comprendido conceptos muy rapidamente. Tu esfuerzo y dedicación hacen una diferencia enorme en nuestra comunidad. ¡Segui así y gracias por compartir tu conocimiento! Vamo Arriba !";

            string commentName9= "@RedbonzaiDEV";
            string commentText9= "I would be grateful to see the CDK code.  Thank you so much for your time in advance.";

        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video = new Video(title, author, lenghtVideo);

        video.AddComment(commentName1, commentText1);
        video.AddComment(commentName2, commentText2);
        video.AddComment(commentName3, commentText3);

        Video video1 = new Video(title1, author1, lenghtVideo1);
        video1.AddComment(commentName4, commentText4);
        video1.AddComment(commentName5, commentText5);
        video1.AddComment(commentName6, commentText6);

        Video video2 = new Video(title2, author2, lenghtVideo2);
        video2.AddComment(commentName7, commentText7);
        video2.AddComment(commentName8, commentText8);
        video2.AddComment(commentName9, commentText9);
        
        List<Video> videos = new List<Video>(){video,video1,video2};
        
        Console.Clear();
        foreach(Video v in videos)
        {
            v.DisplayVideo();
            Console.WriteLine();
        }
        //Console.Clear();
        //video.DisplayVideo();
        //Console.WriteLine();
        //video1.DisplayVideo();
    }
}