运行 DEMO 需要安装 Microsoft Http Client API（Microsoft WCF REST） 以及 WCF REST Service。
首先启动 RESTful.WCFServer，即启动服务端，
然后启动 RESTful.UIClient，即启动客户端，可以在客户端对服务端的数据库中的数据进行增删改查，
也可以在客户端上传图片到服务端或者删除服务端上的图片。
对于服务端的数据库操作路径在 RESTful\RESTful.WCFServer\App_Data\RESTful.db
对于服务端的图片操作目录路径在 RESTful\RESTful.WCFServer\App_Data\Image