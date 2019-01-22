超级美眉（框架）
----
### 开发背景
    也许你会感到好奇，现在已经很多服务端框架了，为什么还要开发超级美眉？  
  
> 每一个程序员都会面临的一个问题，为实现一个业务，反复修改程序数遍，即使程序本身已经没有问题，在客户的需求下，因为要拓展功能而再对程序修改，改到最后变成了自己不想再看的作品。因为程序结构混乱、业务逻辑复杂，再修改时思路不清晰，无论是拓展功能或维护都费时费力，看了就让人烦恼。  
> 
> 因此，超级美眉从哲学和管理学的角度出发，重新审视编程，让程序更加规范、业务逻辑更加清晰明了，让开发更加迅速，并解决拓展功能和维护难题。那么超级美眉要如何才能做到呢？  
>   
  
#### 一、问题相互独立，完全穷尽
* 超级美眉采用插件 + 多路由接口的脚本开发模式每个插件含有多个接口脚本和事件脚本，每个插件负责处理一系列业务，可随时装卸。每个接口脚本负责一块业务，互不干预。例如：文章业务插件，仅有文章频道，文章、文章点评的接口脚本，不会有产品搜索、产品列表等接口。  

然而在现实中，有些业务不可能完全独立，互不干预。例如发布文章需要验证用户身份，并标识该用户是文章的作者，那这时候该怎么办呢？  
    

#### 二、事物常常纵横交错，其行为却井井有条
  要想在确保主业务脚本不改变的情况下，对其相关的事物发生改变，这时超级美眉的事件机制就发挥了作用。超级美眉的事件钩子可以对接口请求进行拦截和控制。可以决定是否触发主业务，也可以触发其他业务，还可以决定主业务发生后返回的结果。  
  例如：在发布文章前，可以验证用户是否有权限发布，并验证发布内容是否符合规范，以及文章发布后给用户奖励积分。  
  那么，超级美眉的事件机制又是如何实现以上所述的呢？  

#### 三、世间万物，皆有因果
  所以超级美眉事件机制决定了业务的因果。将事物的发展过程分为三个阶段，每个阶段有三个时态。三个阶段分别是检查阶段、执行阶段、渲染阶段。  
- 检查阶段：验证是否满足事物的触发条件。  
- 执行阶段：确定事物造成的影响。  
- 渲染阶段：决定我们看到的结果。  
   
  三个时态分别是：行为前、主行为、行为后。  
  行为前和行为后挂载的是异步函数，可以用于统计和触发关联事物。  
  主行为时态挂载的是主函数，可以改变事物执行的过程和轨迹。检查主行为函数，可以决定是否执行主业务。执行主行为函数可以替换原有的主行为。而渲染主行为函数，可以决定要返回的内容。  
  可以针对不同的业务，去编写事件脚本，这样就能实现业务之间的交互，让事物的行为既复杂又简单。
  可是仍有个疑问，即使脚本化、插件化、接口化、事件化仍然无法让程序规范化，因为即使是单个脚本文件，仍然有很多程序，而程序可能要负责验证、操作数据库和获取外部数据。又如何能让程序规范化呢？  

#### 四、无规矩不成方圆
  所以超级美眉还提供了参数验证机制、数据库操作机制、抓包机制。  
参数验证机制提供了一套完整的验证规则，通过编写*.check.json文件，验证参数的类型、长度、格式、数值范围大小等是否正确，决定是否执行主业务以及提示用户操作。  
  数据库操作机制提供了一套完整的sql操作规则，通过编写*.sql.json文件，将传入的参数按照特定的格式组合成sql语句，实现对数据的增删改查以及联表操作。
抓包机制提供了抓取第三数据的规则，通过编写*.catch.json文件，抓取站外数据。  
虽然知道了超级美眉对于开发和维护的好处，上述的种种功能和机制说的是很好，但问题是作为一个新人，上手快吗？开发速度快吗？  

#### 五、大道至简
  如果一个服务端框架需要人花很长的时间去学习才能上手，那么这个服务端说得再好，那也只能说可能是负载好，性能好，稳定性好，或者说是安全性好。但是即使框本身具有这么多种好，上手难，开发难就意味着在编写业务逻辑时可能会出现更多BUG，要知道大部分BUG本来就是出在业务逻辑上。那么再说负载好，性能好，稳定性好，那都是空话。  
  因此，超级美眉还封装了大量类库，并统一了函数名称，常见的函数名称有：“Add、Del、Set、Get、Has、List、Import、Export、Load、Save”等，不到20个。适用于对文件、网络、数据库、缓存等操作。并且python、JavaScript、C#脚本通用。  
只要对编程入门了的人，都可以快速上手编写复杂的程序。7天即可玩转超级美眉服务端。  
