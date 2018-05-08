// This file has been autogenerated from a class added in the UI designer.

using System;
using AppKit;
using MvvmCross.Platforms.Mac.Views;

namespace Playground.Mac
{
    [MvxFromStoryboard("Main")]
    public partial class ToolbarWindow : MvxWindowController
    {
        private static int _count;

        public ToolbarWindow(IntPtr handle) : base(handle)
        {
            _count++;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public NSTextField TextTitle => textTitle;

        public NSMenuItem MenuItem1 => menuItem1;

        public NSMenuItem MenuItem2 => menuItem2;

        public NSMenuItem MenuItem3 => menuItem3;

        public NSMenuItem MenuItemSetting => menuItemSetting;

        public NSPopUpButton PopupModes => popupModes;
    }
}