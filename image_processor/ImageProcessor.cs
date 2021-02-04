using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Collections.Generic;

/// <summary>Represents various methods to perform image processing techniques.</summary>
class ImageProcessor
{
    /// <summary>Inverts the color of a list of images <paramref name="filenames"/>.</summary>
      public static void Inverse(string[] filenames)
      {
            Parallel.ForEach(filenames, (imagePath) => 
            {
                Bitmap image = new Bitmap(imagePath);

                Bitmap invertedImage = null;

                using (Bitmap bmpSource = new Bitmap(image))
                {
                    invertedImage = new Bitmap(bmpSource.Width, bmpSource.Height);
                    
                    for (int x = 0; x < bmpSource.Width; x++)
                    {
                        for (int y = 0; y < bmpSource.Height; y++)
                        {
                            Color colorPixel = bmpSource.GetPixel(x, y);

                            colorPixel = Color.FromArgb(255 - colorPixel.R, 255 - colorPixel.G, 255 - colorPixel.B);

                            invertedImage.SetPixel(x, y, colorPixel);
                        }
                    }
                }

                string[] imageNameSplitted = imagePath.Split(new char[] {'/', '.'});
                String newImageName = imageNameSplitted[imageNameSplitted.Length - 2] +
                                        "_inverse." + imageNameSplitted[imageNameSplitted.Length - 1];

                invertedImage.Save(newImageName);
            });
      }

      /// <summary>Changes the color of a list of images<paramref name="filenames"/>to grayscale.</summary>
      public static void Grayscale(string[] filenames)
      {
          Parallel.ForEach(filenames, (imagePath) =>{
                Bitmap image = new Bitmap(imagePath);
                Bitmap grayScaledImage = new Bitmap(image.Width, image.Height);

                using (Graphics g = Graphics.FromImage(grayScaledImage))
                {
                    // Create grayscale color matrix
                    ColorMatrix colorMatrix = new ColorMatrix(
                        new float[][]
                        {
                            new float[] {.3f, .3f, .3f, 0, 0},
                            new float[] {.59f, .59f, .59f, 0, 0},
                            new float[] {.11f, .11f, .11f, 0, 0},
                            new float[] {0, 0, 0, 1, 0},
                            new float[] {0, 0, 0, 0, 1}
                        });

                    using (ImageAttributes attributes = new ImageAttributes())
                    {
                        attributes.SetColorMatrix(colorMatrix);

                        // Draw the original image in the new bitmap using the grayscale color
                        g.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                                    0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                    }
                }

                string[] imageNameSplitted = imagePath.Split(new char[] { '/', '.' });
                String newImageName = imageNameSplitted[imageNameSplitted.Length - 2] +
                                            "_grayscale." + imageNameSplitted[imageNameSplitted.Length - 1];

                grayScaledImage.Save(newImageName);
          });
      }

      /// <summary>Changes the color of a list of images<paramref name="filenames"/>to only black and white values determined by a <paramref name="threshold"/>.</summary>
      public static void BlackWhite(string[] filenames, double threshold)
      {
            Parallel.ForEach(filenames, (imagePath) =>
            {
                  Bitmap image = new Bitmap(imagePath);
                  Bitmap blackAndWhiteImg = new Bitmap(image.Width, image.Height);

                  using (Graphics g = Graphics.FromImage(blackAndWhiteImg))
                  {
                        // Create grayscale color matrix
                        ColorMatrix grayScaleMatrix = new ColorMatrix(
                            new float[][]
                            {
                                new float[] {.3f, .3f, .3f, 0, 0},
                                new float[] {.59f, .59f, .59f, 0, 0},
                                new float[] {.11f, .11f, .11f, 0, 0},
                                new float[] {0, 0, 0, 1, 0},
                                new float[] {0, 0, 0, 0, 1}
                            });

                        ImageAttributes attributes = new ImageAttributes();
                        attributes.SetColorMatrix(grayScaleMatrix);
                        attributes.SetThreshold((float)threshold);
                        Rectangle rectangle = new Rectangle(0, 0, image.Width, image.Height);
                        g.DrawImage(image, rectangle, 0, 0, image.Width,
                                        image.Height, GraphicsUnit.Pixel, attributes);
                  }

                  string[] imageNameSplitted = imagePath.Split(new char[] { '/', '.' });
                  String newImageName = imageNameSplitted[imageNameSplitted.Length - 2] +
                                              "_bw." + imageNameSplitted[imageNameSplitted.Length - 1];

                  blackAndWhiteImg.Save(newImageName);
            });
      }

      /// <summary>Resize various images<paramref name="filenames"/>to a given<paramref name="height"/>.</summary>
      public static void Thumbnail(string[] filenames, int height)
      {
          Parallel.ForEach(filenames, (imagePath) =>
          {
                Bitmap image = new Bitmap(imagePath);
                Bitmap thumbnailImage = new Bitmap(image.Width / (image.Height / height), height);

                using (Graphics g = Graphics.FromImage(thumbnailImage))
                {
                      Rectangle rectangle = new Rectangle(0, 0, image.Width / (image.Height / height), height);
                      g.DrawImage(image, rectangle, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
                }

                string[] imageNameSplitted = imagePath.Split(new char[] { '/', '.' });
                String newImageName = imageNameSplitted[imageNameSplitted.Length - 2] +
                                            "_th." + imageNameSplitted[imageNameSplitted.Length - 1];

                thumbnailImage.Save(newImageName);
          });
      }
}