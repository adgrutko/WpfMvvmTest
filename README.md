# WpfMvvmTest
Simple project demonstrantes how to use MVVM pattern in WPF desktop application.
Project also demonstrates how to add Command and CommandParameter attributes to visual WPF elements (only Button has it out-of-the-box)

![Demo Application Look](https://i.ibb.co/vQKjH0S/WPF-Mvvm-Test.png)

Solution contains two projects:
- WpfMvvmTest: WPF application demonstrating use of MVVM pattern (Model-View-ViewModel)
- WpfMvvmTest.Core: .NET Standard class library containing ViewModel and helpers; technology independence gives opportunity to use it also in Xamarin, UWP or Web application

Microsoft.Xaml.Behaviors.Wpf library is recommended replacement for System.Windows.Interactivity used before. Old library is signed as 'depreciated'.
