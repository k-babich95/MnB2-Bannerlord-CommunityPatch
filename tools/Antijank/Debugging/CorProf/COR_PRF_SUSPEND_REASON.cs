﻿using JetBrains.Annotations;

namespace Antijank.Debugging {

  [PublicAPI]
  public enum COR_PRF_SUSPEND_REASON {

    COR_PRF_SUSPEND_OTHER,

    COR_PRF_SUSPEND_FOR_GC,

    COR_PRF_SUSPEND_FOR_APPDOMAIN_SHUTDOWN,

    COR_PRF_SUSPEND_FOR_CODE_PITCHING,

    COR_PRF_SUSPEND_FOR_SHUTDOWN,

    COR_PRF_SUSPEND_FOR_INPROC_DEBUGGER = 6,

    COR_PRF_SUSPEND_FOR_GC_PREP,

    COR_PRF_SUSPEND_FOR_REJIT

  }

}