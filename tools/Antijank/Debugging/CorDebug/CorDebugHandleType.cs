﻿using JetBrains.Annotations;

namespace Antijank.Debugging {

  [PublicAPI]
  public enum CorDebugHandleType {

    HANDLE_STRONG = 1,

    HANDLE_WEAK_TRACK_RESURRECTION

  }

}