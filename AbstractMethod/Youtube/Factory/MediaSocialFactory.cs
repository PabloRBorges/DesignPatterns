﻿using AbstractFactoryMethod.Youtube.Abstract.Products;
using AbstractFactoryMethod.Youtube.Factory.Products;
using AbstractFactoryMethod.Youtube.Abstract;

namespace AbstractFactoryMethod.Youtube.Factory
{
    public class MediaSocialFactory : AbstractFactorys
    {
        public override MediaSocial CreateMediaSocial()
        {
            return new MediaSocialFacebook();
        }
    }
}