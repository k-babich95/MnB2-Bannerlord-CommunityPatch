﻿using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using JetBrains.Annotations;

namespace Antijank.Debugging {

  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("34625881-7EB3-4524-817B-8DB9D064C760")]
  [SuppressUnmanagedCodeSecurity]
  [ComImport]
  [PublicAPI]
  public interface IXCLRDataModule2 {

    [MethodImpl(MethodImplOptions.InternalCall)]
    void SetJITCompilerFlags([In] uint dwFlags);

  }

}