﻿using System.Runtime.InteropServices;


namespace Antijank.Debugging {

  [CoClass(typeof(CLRRuntimeHostClass))]
  [Guid("90F1A06C-7712-4762-86B5-7A5EBA6BDB02")]
  [ComImport]
  
  public interface CLRRuntimeHost : ICLRRuntimeHost {

  }

}