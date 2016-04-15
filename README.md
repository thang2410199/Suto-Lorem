# Suto-Lorem

Open source library for UWP app. Generate random words, sentences, paragraph, avatar images, placeholder images and random images.

# Usage

    var imageProvider = new SutoLorem.LoremImage();
    var textProvider = new SutoLorem.LoremText();
    ImageSource = imageProvider.GetAvatar();
    Placeholder = imageProvider.GetPlaceholder(300, 200);
    paragraph.Text = textProvider.GetParagraph(3);
