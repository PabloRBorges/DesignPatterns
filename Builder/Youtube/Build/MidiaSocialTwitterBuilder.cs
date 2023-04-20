using Builder.Youtube.Products;
using System;

namespace Builder.Youtube.Build
{
    class MidiaSocialTwitterBuilder : MidiaSocialBuilder
    {
        public MidiaSocialTwitterBuilder()
        {
            _mediaSocial = new MidiaSocial("Twitter", ConsoleColor.Cyan);
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
