﻿// Decompiled with JetBrains decompiler
// Type: RGiesecke.DllExport.ExtractExportHandler
// Assembly: RGiesecke.DllExport, Version=1.2.7.38850, Culture=neutral, PublicKeyToken=8f52d83c1a22df51
// MVID: C9BFF197-CAB3-40A6-BA31-9260266DE1B7
// Assembly location: C:\Users\k.gosse\.nuget\packages\unmanagedexports.repack\1.0.0\tasks\RGiesecke.DllExport.dll

using Mono.Cecil;

namespace RGiesecke.DllExport
{
  internal delegate bool ExtractExportHandler(
    MethodDefinition memberInfo,
    out IExportInfo exportInfo);
}
