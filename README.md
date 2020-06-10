<p align="center">
  <span>中文</span> |  
  <a href="https://github.com/dotnetcore/natasha/tree/master/lang/english">English</a>
</p>
<p align="center"> <span>你们的反馈是我的动力，文档还有很多不足之处；</span> </p>
<p align="center"> <span> 当你看完文档之后仍然不知道如何实现你的需求，您可以查看<a href="https://github.com/dotnetcore/Natasha/blob/master/docs/FAQ.md"> FAQ </a>或者在issue中提出你的需求。</span> </p>


# Natasha 

[![Member project of .NET Core Community](https://img.shields.io/badge/member%20project%20of-NCC-9e20c9.svg)](https://github.com/dotnetcore)
[![NuGet Badge](https://buildstats.info/nuget/DotNetCore.Natasha?includePreReleases=true)](https://www.nuget.org/packages/DotNetCore.Natasha)
[![Gitter](https://badges.gitter.im/dotnetcore/natasha.svg)](https://gitter.im/dotnetcore/Natasha?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)
[![Badge](https://img.shields.io/badge/link-996.icu-red.svg)](https://996.icu/#/zh_CN)
[![GitHub license](https://img.shields.io/github/license/dotnetcore/natasha.svg)](https://github.com/dotnetcore/Natasha/blob/master/LICENSE)

&ensp;&ensp;&ensp;&ensp;基于 [Roslyn](https://github.com/dotnet/roslyn) 的动态编译库，为您提供高效率、高性能、可追踪的动态构建方案，兼容 stanadard2.0/netcoreapp3.0+ , 只需原生C#语法不用Emit, [更多的动图展示](https://github.com/dotnetcore/Natasha/blob/master/docs/zh/gif.md)。
让您的动态方法更加容易编写、跟踪、维护。


 ![展示](https://github.com/dotnetcore/Natasha/blob/master/Image/Natasha.gif)
<br/>

### 类库信息(Library Info)  

[![GitHub tag (latest SemVer)](https://img.shields.io/github/tag/dotnetcore/natasha.svg)](https://github.com/dotnetcore/Natasha/releases) ![GitHub repo size](https://img.shields.io/github/repo-size/dotnetcore/Natasha.svg) [![GitHub commit activity](https://img.shields.io/github/commit-activity/m/dotnetcore/natasha.svg)](https://github.com/dotnetcore/Natasha/commits/master) [![Codecov](https://img.shields.io/codecov/c/github/dotnetcore/natasha.svg)](https://codecov.io/gh/dotnetcore/Natasha)  

| Scan Name | Status |
|--------- |------------- |
| Document | [![wiki](https://img.shields.io/badge/wiki-ch-blue.svg)](https://natasha.dotnetcore.xyz/) |
| Lang | ![Compile](https://img.shields.io/badge/script-csharp-green.svg)|
| OS | ![Windows](https://img.shields.io/badge/os-windows-black.svg) ![linux](https://img.shields.io/badge/os-linux-black.svg) ![mac](https://img.shields.io/badge/os-mac-black.svg)|
| Rumtime | ![standard](https://img.shields.io/badge/platform-standard2.0-blue.svg) ![standard](https://img.shields.io/badge/platform-netcore3.0-blue.svg) ![standard](https://img.shields.io/badge/platform-netcore3.1-blue.svg)| 

<br/>  

### 持续构建(CI Build Status)  

| CI Platform | Build Server | Master Build  | Master Test |
|--------- |------------- |---------| --------|
| Github | linux/mac/windows | [![Build status](https://img.shields.io/github/workflow/status/dotnetcore/Natasha/.NET%20Core/master)](https://github.com/dotnetcore/Natasha/actions) ||
| Azure |  Windows |[![Build Status](https://dev.azure.com/NightMoonStudio/Natasha/_apis/build/status/dotnetcore.Natasha?branchName=master&jobName=Windows)](https://dev.azure.com/NightMoonStudio/Natasha/_build/latest?definitionId=3&branchName=master)|[![Build Status](https://img.shields.io/azure-devops/tests/NightMoonStudio/Natasha/3/master.svg)](https://dev.azure.com/NightMoonStudio/Natasha/_build/latest?definitionId=3&branchName=master) |
| Azure |  Linux |[![Build Status](https://dev.azure.com/NightMoonStudio/Natasha/_apis/build/status/dotnetcore.Natasha?branchName=master&jobName=Linux)](https://dev.azure.com/NightMoonStudio/Natasha/_build/latest?definitionId=3&branchName=master)|[![Build Status](https://img.shields.io/azure-devops/tests/NightMoonStudio/Natasha/3/master.svg)](https://dev.azure.com/NightMoonStudio/Natasha/_build/latest?definitionId=3&branchName=master) | 
| Azure |  Mac |[![Build Status](https://dev.azure.com/NightMoonStudio/Natasha/_apis/build/status/dotnetcore.Natasha?branchName=master&jobName=macOS)](https://dev.azure.com/NightMoonStudio/Natasha/_build/latest?definitionId=3&branchName=master)|[![Build Status](https://img.shields.io/azure-devops/tests/NightMoonStudio/Natasha/3/master.svg)](https://dev.azure.com/NightMoonStudio/Natasha/_build/latest?definitionId=3&branchName=master) | 


<br/>    

### 使用方法(User Api)：  

 <br/>  
 
 - 引入 动态构建库： DotNetCore.Natasha

 - 引入 编译环境库： DotNetCore.Compile.Environment

 - 向引擎中注入定制的域：  
  - 3.10.0.0 版本以前： DomainManagement.RegisterDefault< AssemblyDomain >();
  - 3.10.0.0 版本及以后： AssemblyDomain.Init();

 - 敲代码  
 
 
 > 更多更新的参考文档：https://natasha.dotnetcore.xyz/  
 
<br/>  


### 发布日志  
      
  
  - 2020-05-01 ： 发布v3.0.0.0, 重构所有模块，上层API几乎没变，底层可以继承重写，移除部分 API。  
  
  - 2020-05-06 ： 发布v3.0.2.0, 修复 修饰符模板状态机BUG, 增加 语法树选项 ForceAddSyntax 不管对错强制添加语法树。  
  
  - 2020-05-12 ： 发布v3.2.0.0，增加插件自动装载 using 的功能，修复部分字段命名，Domain 部分抽象实现将在 AssemblyDomain 中实现，增加 GetPluginAssembies 抽象方法以返回插件带来的程序集，需要子类实现。
    
  - 2020-06-01 ： 发布v3.4.0.0，Oop 模板增加两种内容构造API , nclass.GetXXXBuilder 返回构造器，用户可以在外随意定制， nclass.Property/Field/Method/Ctor( builder) 支持直接传一个完好的 builder 进去。

  - 2020-06-06 ： 发布v3.8.0.0，修复模板状态机操作； 模板中API调整：DefinedName -> Name, DefinedType -> Type; 调整引擎 API 结构，减少 AssemblyCSharpBuilder 类 API 操作的层级；增加对私有字段动态调用的支持，OOP 模板新增API AllowPrivate； 由于精力有限周边项目将只对 R2D \ DynamicaCache 进行更新。
  
  - 2020-06-07 ： 发布v3.10.0.0，分离 SDK / SHARE 运行时库引用，以便支持系统类库的私有字段。调整初始化 API `DomainManagement.RegiestDefault` => ` AssemblyDomain.Init();`； 引擎继续调整 API 结构，提升部分属性的暴露层级： AllowUnsafe 属性以支持非安全代码编译；OutputToFile 切换内存及文件编译模式；UseRelease 是否使用优化编译；OutputKind 编译类型的枚举，包括 dll / exe 等； Domain 域设置； AssemblyName 程序集名。精简引擎部分冗余代码。
  
 <br/>  
 
### 开发计划  

#### 分支 NoPublish  

 - [x] 分离 share 库，并作为域操作的一个选项。  
 - [x] 使用委托或Emit优化部分反射操作。  
 - [ ] 增加并发库/常见内置类型的 share 引用测试。  
 - [x] 编译异常信息作为 Message 直接展示。  
 - [x] 调研编译环境继承的解决方案。    
 
> 欢迎大家提交PR 

  <br/>  
 

### 性能测试
      
   - [x]  **动态调用性能测试（对照组： emit, origin）**  
     ![字段性能测试](https://github.com/dotnetcore/Natasha/blob/master/Image/Natasha%E6%80%A7%E8%83%BD%E6%B5%8B%E8%AF%951.png)
   - [x]  **动态初始化性能测试（对照组： emit, origin）**  
     ![初始化性能测试](https://github.com/dotnetcore/Natasha/blob/master/Image/Natasha%E6%80%A7%E8%83%BD%E6%B5%8B%E8%AF%952.png)
   - [x]  **内存及CPU监测截图**  
     ![内存及CPU](https://github.com/dotnetcore/Natasha/blob/master/Image/%E8%B5%84%E6%BA%90%E7%9B%91%E6%B5%8B.png) 
     

<br/>    

### Wiki审核
                             
Teng(359768998@qq.com)

<br/>    

### 代码审核

WeihanLi

<br/>    

 ### 升级日志
 
 - [[2019]](https://github.com/dotnetcore/Natasha/blob/master/docs/zh/update/2019.md)
 - [[2020]](https://github.com/dotnetcore/Natasha/blob/master/docs/zh/update/2020.md)
 <br/>  
 
 

 ### 生态微信群  
 
为防止广告骚扰，微信群已关闭，进群请发送您的微信号到 2765968624@qq.com 并说明进群原因。
如果未及时处理，请在 issue 中提醒我，QQ我平时不上了。  (发广告的先死个妈) 
 
 
  <br/>  


  #### Natasha的动态调用模块:  已移至[【NCaller】](https://github.com/night-moon-studio/NCaller)
  #### Natasha的动态克隆模块:  已移至[【DeepClone】](https://github.com/night-moon-studio/DeepClone)  
  #### 查找树算法:  [【BTFindTreee】](https://github.com/dotnet-lab/BTFindTreee)  
  #### 快速动态缓存:  [【DynamicCache】](https://github.com/night-moon-studio/DynamicCache)  
  
<br/>
<br/>    


---------------------  


## License
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2Fdotnetcore%2FNatasha.svg?type=large)](https://app.fossa.io/projects/git%2Bgithub.com%2Fdotnetcore%2FNatasha?ref=badge_large)          
      

