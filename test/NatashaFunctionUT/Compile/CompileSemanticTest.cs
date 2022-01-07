﻿using Microsoft.CodeAnalysis.CSharp;
using Natasha.CSharp.Error.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NatashaFunctionUT.Compile
{
    [Trait("基础功能测试", "编译")]
    public class CompileSemanticTest : DomainPrepare
    {
        [Fact(DisplayName = "[语义过滤]编译测试")]
        public void SemanticTest1()
        {

            var code = DefaultUsing.UsingScript + "public class A{ public string Name;}";
            AssemblyCSharpBuilder builder = new();
            builder.Domain = DomainManagement.Random();
            builder.EnableSemanticHandler = false;
            builder.Add(code);
            Assert.Equal(DefaultUsing.Count, builder.SyntaxTrees[0].GetCompilationUnitRoot().Usings.Count);

            try
            {
                var assemly = builder.GetAssembly();

                Assert.True(false);
            }
            catch (Exception ex)
            {
                var nex = ex as NatashaException;
                Assert.NotNull(nex);
                Assert.Equal(ExceptionKind.Compile, nex!.ErrorKind);
                Assert.Equal(DefaultUsingCount, builder.SyntaxTrees[0].GetCompilationUnitRoot().Usings.Count);
                Assert.Equal(DefaultUsingCount, DefaultUsing.Count);
            }

            builder.EnableSemanticHandler = true;
            var succeedAssembly = builder.GetAssembly();
            Assert.NotNull(succeedAssembly);
            Assert.Equal(builder.AssemblyName,succeedAssembly.GetName().Name);
            Assert.NotEqual(DefaultUsingCount, DefaultUsing.Count);
            Assert.NotEqual(DefaultUsingCount, builder.SyntaxTrees[0].GetCompilationUnitRoot().Usings.Count);
            Assert.Empty(builder.SyntaxTrees[0].GetCompilationUnitRoot().Usings);


        }
    }
}
