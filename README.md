# CustomsParking

#### 项目介绍
海关停车场服务系统，通过捷顺提供的SDK，实现控制。

#### 软件架构
软件架构说明


#### 安装教程

1. xxxx
2. xxxx
3. xxxx

#### 使用说明

1. JNAProject文件夹中，是调用底层接口的动态库项目；
大致原理是使用jna调用C#的DLL需要C++做中间件，因为C#的代码托管到.NET平台上，java不能直接调用。但是C++可以，流程为：c++调用写好的c#的dll，java再调用c++生成的dll中间件
2. CustomsParking/JNAProject/CSharpDEMO/libs文件夹下有两个dll，其中【Newtonsoft.Json.dll】要添加到项目的引用中去，替换掉最原始的Newtonsoft.Json.dll引用文件，【SmartDevice.dll】要放到JDK的bin目录中；
3. 项目CSharpDEMO所生成的dll和子项目RePackLib所生成的dll也要同时拷贝到JDK的bin目录中；
4、

#### 参与贡献

1. Fork 本项目
2. 新建 Feat_xxx 分支
3. 提交代码
4. 新建 Pull Request


#### 码云特技

1. 使用 Readme\_XXX.md 来支持不同的语言，例如 Readme\_en.md, Readme\_zh.md
2. 码云官方博客 [blog.gitee.com](https://blog.gitee.com)
3. 你可以 [https://gitee.com/explore](https://gitee.com/explore) 这个地址来了解码云上的优秀开源项目
4. [GVP](https://gitee.com/gvp) 全称是码云最有价值开源项目，是码云综合评定出的优秀开源项目
5. 码云官方提供的使用手册 [http://git.mydoc.io/](http://git.mydoc.io/)
6. 码云封面人物是一档用来展示码云会员风采的栏目 [https://gitee.com/gitee-stars/](https://gitee.com/gitee-stars/)