using Builder.Youtube.Products;
using System;

namespace Builder.Youtube.Build
{
    class MidiaSocialFacebookBuilder : MidiaSocialBuilder
    {
        public MidiaSocialFacebookBuilder()
        {
            _mediaSocial = new MidiaSocial("Facebook", ConsoleColor.Blue);
        }

        public override void BuildLike()
        {
            _mediaSocial.Like("Publicação da Microsoft");
        }

        public override void BuildPost()
        {
            _mediaSocial.Post("Titulo da publicação", body: $"Minha primeira publicação no {_mediaSocial.RedeNome}");
        }
    }
}
