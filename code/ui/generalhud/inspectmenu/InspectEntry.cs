using Sandbox;
using Sandbox.UI.Construct;

using TTTReborn.Globalization;

namespace TTTReborn.UI
{
    public class InspectEntry : Panel
    {
        public TranslationData TranslationData;
        private readonly Sandbox.UI.Image _inspectIcon;
        private readonly TranslationLabel _inspectQuickLabel;

        public InspectEntry(Panel parent) : base(parent)
        {
            Parent = parent;

            AddClass("rounded");
            AddClass("text-shadow");
            AddClass("background-color-secondary");

            _inspectIcon = Add.Image();
            _inspectIcon.AddClass("inspect-icon");

            _inspectQuickLabel = Add.TranslationLabel(new TranslationData());
            _inspectQuickLabel.AddClass("quick-label");
        }

        public void SetData(string imagePath, TranslationData translationData)
        {
            SetTranslationData(translationData);

            _inspectIcon.Style.BackgroundImage = Texture.Load(imagePath, false) ?? Texture.Load($"/ui/none.png");
        }

        public void SetTranslationData(TranslationData translationData)
        {
            TranslationData = translationData;
        }

        public void SetQuickInfo(TranslationData translationData)
        {
            _inspectQuickLabel.SetTranslation(translationData);
        }
    }
}
