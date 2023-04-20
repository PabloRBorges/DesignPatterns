using Builder.Youtube.Products;

namespace Builder.Youtube.Build
{
    abstract class MidiaSocialBuilder
    {
        protected MidiaSocial _mediaSocial;
        public MidiaSocial Midia => _mediaSocial;

        public abstract void BuildPost();
        public abstract void BuildLike();
    }
}
