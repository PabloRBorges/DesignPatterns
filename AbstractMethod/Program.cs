using AbstractFactory.Site;
using AbstractFactoryMethod.Youtube.Abstract;
using AbstractFactoryMethod.Youtube.Factory;
using AbstractFactoryMethod.Youtube.Factory.Products;
using System;

namespace AbstractMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //AbstractFactory factory = new MediaSocialFactory();

            //var MediaSocial = factory.CreateMediaSocial();

            //MediaSocial.Post(title: "Titulo do Post", body: "Minha primeira publiação no ");
            //MediaSocial.Like();


            Client client  = new Client();

            client.Main();
        }
    }
}
