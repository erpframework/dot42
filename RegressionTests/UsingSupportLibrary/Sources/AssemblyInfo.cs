﻿using Dot42;
using Dot42.Manifest;

[assembly: Application("dot42 Using Support Lib")]
[assembly: Instrumentation(Label = "dot42 UsingSupportLib Tests", FunctionalTest = true)]
[assembly: UsesLibrary("android.test.runner")]