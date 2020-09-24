﻿using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace HandyEmit.SmartEmit.Field
{
    public class FieldInt64 : CanCompute<Int64>
    {
        internal FieldInt64(LocalBuilder stack, ILGenerator il) : base(stack, il)
        {
        }
    }
}