﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HandyEmit.Enums
{
    /// <summary>
    /// 常用修饰符(便捷)
    /// </summary>
    public enum Qualifier
    {
        Public = TypeAttributes.Public | TypeAttributes.AutoClass | TypeAttributes.AnsiClass | TypeAttributes.BeforeFieldInit,
        PublicOrAbstract = TypeAttributes.Public | TypeAttributes.Abstract | TypeAttributes.AutoClass | TypeAttributes.AnsiClass | TypeAttributes.BeforeFieldInit,
        PublicOrStatic = TypeAttributes.Public | TypeAttributes.Abstract | TypeAttributes.Sealed | TypeAttributes.AutoClass | TypeAttributes.AnsiClass | TypeAttributes.BeforeFieldInit,
        Private = TypeAttributes.NotPublic | TypeAttributes.AutoClass | TypeAttributes.AnsiClass | TypeAttributes.BeforeFieldInit,
        PrivateOrAbstract = TypeAttributes.NotPublic | TypeAttributes.Abstract | TypeAttributes.AutoClass | TypeAttributes.AnsiClass | TypeAttributes.BeforeFieldInit,
        PrivateOrStatic = TypeAttributes.NotPublic | TypeAttributes.Abstract | TypeAttributes.Sealed | TypeAttributes.AutoClass | TypeAttributes.AnsiClass | TypeAttributes.BeforeFieldInit,
        PublicOrInterface = TypeAttributes.Public | TypeAttributes.Interface | TypeAttributes.Abstract | TypeAttributes.AutoClass | TypeAttributes.AnsiClass,
        PrivateOrInterface = TypeAttributes.NotPublic | TypeAttributes.Interface | TypeAttributes.Abstract | TypeAttributes.AutoClass | TypeAttributes.AnsiClass,
        Struct = TypeAttributes.Public | TypeAttributes.Sealed | TypeAttributes.SequentialLayout | TypeAttributes.AnsiClass | TypeAttributes.BeforeFieldInit
    }
}