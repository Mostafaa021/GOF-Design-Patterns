namespace Adapter_Pattern;

class Program
{
    static void Main(string[] args)
    {
        // Use Library A
        IImageResizer resizerA = new LibraryAImageResizerAdapter();
        var processorA = new ImageProcessor(resizerA); // constructor take something of type IImageResizer which implemented by concrete adapter
        processorA.ProcessImage(800, 600);  // Library A: Resized image to 800x600

        // Use Library B
        IImageResizer resizerB = new LibraryBImageResizerAdapter();
        var processorB = new ImageProcessor(resizerB);
        processorB.ProcessImage(1024, 768);  // Library B: Resized image to 1024x768
    }
}