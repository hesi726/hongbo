# hongbo
自己公司使用的代码，

#hongboExtension
对标准类的扩展

# hongboPrivilege
自己公司使用的权限控制代码  
因为公司较小，权限变化不大（一般不会定义新的权限或者删除权限）  
所以权限存放在常量，而没有存放在数据库中；
这样，就可以在 Controller 上定义 Attribute 来进行授权控制      
也可以在 Action 上定义 Attribute 来控制控制  
还可以根据 Action 的某一个参数，根据参数类型和参数值：   
1. 参数类型为字符串时，解析参数值对应的类型，通过在此类型上的定义的 Attribute ， 从而对这个 Action 进行授权控制，    
2. 参数类型为枚举类型，解析参数值对应的枚举值，解析此枚举值上所定义的Attribute,从而控制对这个 Action 的授权控制，  

Accord the url, https://docs.microsoft.com/en-us/dotnet/core/tutorials/libraries#how-to-multitarget
but there is one question, for example, you set the targetframeworks to net46, but in your code, you use the net45, it will not defined net45;