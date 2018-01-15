﻿using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.WindowsUWP.Platform;
using Windows.UI.Xaml.Controls;

namespace Training.UWP
{
    internal sealed class Setup : MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
            
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.CoreApp();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}