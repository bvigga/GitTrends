﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GitTrends.Mobile.Common.Constants {
    using System;
    using System.Reflection;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class TrendsChartTitleConstants {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TrendsChartTitleConstants() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("GitTrends.Mobile.Common.Constants.TrendsChartTitleConstants", typeof(TrendsChartTitleConstants).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        public static string TotalViewsTitle {
            get {
                return ResourceManager.GetString("TotalViewsTitle", resourceCulture);
            }
        }
        
        public static string UniqueViewsTitle {
            get {
                return ResourceManager.GetString("UniqueViewsTitle", resourceCulture);
            }
        }
        
        public static string TotalClonesTitle {
            get {
                return ResourceManager.GetString("TotalClonesTitle", resourceCulture);
            }
        }
        
        public static string UniqueClonesTitle {
            get {
                return ResourceManager.GetString("UniqueClonesTitle", resourceCulture);
            }
        }
        
        public static string All {
            get {
                return ResourceManager.GetString("All", resourceCulture);
            }
        }
        
        public static string NoUniques {
            get {
                return ResourceManager.GetString("NoUniques", resourceCulture);
            }
        }
        
        public static string JustUniques {
            get {
                return ResourceManager.GetString("JustUniques", resourceCulture);
            }
        }
    }
}
