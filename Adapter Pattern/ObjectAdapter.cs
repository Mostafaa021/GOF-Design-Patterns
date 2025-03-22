namespace Adapter_Pattern;



 // object adapter
 // wrapper 

 // the adapter pattern is a structural design pattern
 // that allows objects with incompatible interfaces to collaborate 
 // or in another meaning  it converts the interface of a class into another interface the client expects
 // it lets classes work together that couldn't otherwise because of incompatible interfaces

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
 public class LibraryAImageResizerAdapter : IImageResizer // adapter
 {
  private readonly LibraryAImageResizer _resizer = new();
  public void ResizeImage(int width, int height)
  {
   _resizer.Resize(width, height); // here the adaptation is done by converting the method name to match the client's expectation
  }
 }

 // Adapter Class for Library B
 public class LibraryBImageResizerAdapter : IImageResizer // adapter
 {
  private readonly LibraryBImageResizer _resizer = new();
  public void ResizeImage(int width, int height)
  {
   _resizer.SetSize(width, height); // here the adaptation is done by converting the method name to match the client's expectation
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
 

 
