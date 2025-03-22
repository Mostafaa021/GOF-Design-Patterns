namespace Adapter_Pattern;

// class adapter
public class ClassAdapter
{
     // Library A's Image Resizer first option 
     public class LibraryAImageResizer  // adaptee
     {
      public void Resize(int width, int height)
      {
       Console.WriteLine($"Library A: Resized image to {width}x{height}");
      }
     }
    
    // Library B's Image Resizer second option
     public class LibraryBImageResizer // adaptee
     {
      public void  SetSize(int newWidth, int newHeight)
      {
       Console.WriteLine($"Library B: Resized image to {newWidth}x{newHeight}");
      }
     }
    
     // Target Interface 
     public interface IImageResizer // target
     {
      void ResizeImage(int width, int height);
     }
    
     // Adapter Class for Library A 
     public class LibraryAImageResizerAdapter : LibraryAImageResizer ,  IImageResizer // adapter
     {
      public void ResizeImage(int width, int height)
      {
       base.Resize(width, height); // here the adaptation is done by converting the method name to match the client's expectation
      }
     }
    
     // Adapter Class for Library B
     public class LibraryBImageResizerAdapter : LibraryBImageResizer , IImageResizer // adapter
     {
      public void ResizeImage(int width, int height)
      {
       base.SetSize(width, height); // here the adaptation is done by converting the method name to match the client's expectation
      }
     }
    
    
     // Client Code (directly using Library A)
     public class ImageProcessor
     {
      private readonly IImageResizer _resizer ;
    
      public ImageProcessor(IImageResizer resizer)
      {
       _resizer = resizer; 
      }
      public void ProcessImage(int width, int height)
      {
       _resizer.ResizeImage(width, height); // here is abstraction of the client code to use the adapter
      }
     }
}