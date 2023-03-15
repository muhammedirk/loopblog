using System;

namespace LoopBlog.Data.Enums {
    [Flags]
    public enum Permission {
        Read,
        Edit,
        Delete
    }
}