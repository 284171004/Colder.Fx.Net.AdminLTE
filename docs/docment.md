# Colder���ٿ�������ĵ�(NET452+AdminLTE��)

#1.���

�����ּ�ڼ������߿���Ч��

ʹ�ü���ջ��
��ˣ�����.NETƽ̨��ASP.NET MVC��C#���ԣ�ʹ�÷���ȸ߼���������Entity Framework�����ݿ�ORM��ܣ���
ʹ�����ݲִ�ģʽ���������ݿ����(CRUD��)��֧���������Լ��ֲ�ʽ��������⣩
֧�����ݿ��д���롢�ֿ�ֱ�����(��֧�ֵ������,��֧�ֶ��) ȫ�����Autofac��ΪIOC����,����ӿڱ��,ȫ�����
����ϵͳSession,ʹ���Զ���Session�����ϵͳ����
���ɶ��ֹ�������Լ�������չ
���ݿ⣺SqlServer�����ʹ�ü򵥹������������������󹤳��������ɸ������ݿ⣩,Redis��Ϊ�ֲ�ʽ����
ǰ�ˣ�HTML5,JS,JQuery,Bootstrap����Ҫǰ�˿�ܣ�,AdminLTE����̨ģ�壩�����м��ɶ���JS��������󷽱���Ŀ������ 

���弼��ʵʩ��
��Ŀ����ǰ�����ȫ����ģʽ���������ϸ�ֲ�ģʽ����������Ӿۺ϶ȣ�������϶ȣ�
��ߴ���Ľ�׳�ԣ���ά���ԡ�
ǰ���ͨ�����ݽӿڲ������ݣ�ͳһʹ��JSON��Ϊ���ݸ�ʽ����ʹ��Ĭ�Ͻӿ�ǩ���㷨��֤�ӿڵİ�ȫ�ԡ� 

���ܼܹ�������⣺
���ٿ������˹���Ϊ��ܵĺ��ģ�ͨ��ѡ�����ݿ��еı������Զ����ɶ�Ӧ��ʵ��㡢ҵ���߼��㡢����������ͼ���Լ���Ӧ�����ã��������д���뼴�����ɻ�����CRUD������
�ӿ���Կ��������ӿڵ���Կ���������ӿ�ǩ���Ĺ�����ǰ����Ҫͨ�����ӿ�ǩ�����ܹ��������ʺ�̨�ӿڡ�
Ȩ�޹����ṩ��ȫ��Ȩ�޹����ܣ�֧�ָ�ϵͳ�û���ϵͳ��ɫ�Ͷ���ӿ�AppId����Ȩ�� 

����ذ汾�뿴�±�

| **.NET�汾** | **ǰ��UI** | **��ַ** |
|-|||
| .NET4.52| AdminLTE   | <https://github.com/Coldairarrow/Colder.Fx.Net.AdminLTE>              |
| .NET4.52     | Easyui     | <https://github.com/Coldairarrow/Coldairarrow.Fx.Net.Easyui.GitHub>   |
| .NET Core2.1 | Easyui     | <https://github.com/Coldairarrow/Coldairarrow.Fx.Core.Easyui.GitHub>  |
| .NET4.0      | Easyui     | <https://github.com/Coldairarrow/Coldairarrow.Fx.Net40.Easyui.GitHub> |

��̨չʾ���£�

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/4397a1708d4b134325e9c264b00e180b.png)

����׼��
========

��������Ҫ��
------------

����ϵͳ��Windows 10

�������ߣ�Visual Studio 2017

SDK����װ.NET4.52������

���ݿ⣺SQLServer2008 R2������

�������ݿ⹹��
--------------

ʹ�ñ������Ҫ�����������ݿ⣬���岽�����£�

�����������ݿ��Sql�ű��ļ��ڣ�/docs/��ʼ���ļ�/db.sql�������ݿ�������db.sql�ű����ɴ������ݿ�:
Colder.Fx.Net.AdminLTE

��Sql���г�����ֱ��ʹ��ͬĿ¼�µ�db.bak��ԭ���ݿ�

��srcĿ¼��Colder.Fx.Net.AdminLTE�Ľ������������ͼ

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/bf515908fa1475c05265920466f4aee3.png)

����ͼ��ʾ����չ��05.Coldairarrow.Web=\>Config=\>database.config���������ݿ������ַ�����name�����޸ģ�connectionString��Ϊ�������������ݿ⣨����������ݿ������ַ��������аٶ������̳̣�

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/9198e1dd732803ef99d5b8ddeea7daba.png)

�Դ˻������ݿ�������ɡ�

���ݿ���ƹ淶
--------------

���ڱ����֧���Զ����ɴ���ĺ��Ĺ��ܣ��˹����Ǹ������ݿ�ı�ṹ�����ɴ����

��˹涨ÿ�ű���һ������������ΪId������Ϊ�ַ�����ʵ���������ʱĬ��ʹ��GUID���ַ�����ʽ�����е�ÿ���ж���Ҫ��������Ϣ�����������������������������׼����ҪһЩ����ĸĶ����ܹ��ɹ����У���

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/2036647b5267b02aa537f563b66b7647.png)

����
----

���Ȼ�ԭNuget��

Ȼ��05.Coldairarrow.Web��Ϊ������Ŀ���ɹ����м��ɽ�������ҳ��

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/4397a1708d4b134325e9c264b00e180b.png)

��ϸ�̳�
========

����ܹ�
--------

### ����ܹ�

![WEB��̨���ٿ������ϵͳ�ܹ���� (4)](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/aeedbeae75be3a7a8cee3c6dcd8fcbd2.png)

�����ɽṹһ����Ϊ5�㣬����ͼ��ʾ���ֱ����£�

������ʩ�㣺�˲�Ϊ��ײ㣬����Ϊ�������в������Ҫ�ṩ����Ŀ��������ĸ��ְ����ࣺ���ݿ���ʰ����ࡢ�ļ����������ࡢ��ά�����ɰ����ࡢ�ּ�ѹ��������ȵ���������ࣻ��չ�ࣺ�ַ�����չ�ࡢ���ϲ�����չ�ࡢ���ʽ����չ��ȵ�������չ�ࣻ�������˸��˱�д��SocketͨѶ��ܣ�WCF��չʹ�ÿ�ܣ�Windows������������Щ�ḻ����ⶼ��Ϊ������Ա�ṩ�˿����г��õĹ��ܣ�Ϊ���ٿ����ṩǿ�����ı��ϡ�

���ݲִ��㣺�����ҪΪ�����ݿ����CRUD�ļ򵥷�װ����EntityFrameworkΪ���ģ����ü򵥹��������󹤳������������������������ģʽ��ʹ������Ա����CRUDֻ��Ҫ��Ϊ�򵥵Ĵ��뼴����ɡ����㻹�ṩ�����ݿ������֧�֣������ṩ�˷ֲ�ʽ����֧�֣�Ϊ���ݿ�����ṩ�ر��ı��ϡ�ʹ�ñ����ṩ�Ľӿڣ�������ľ�������ݿ����ͣ������ǲ���SQLServer���ݿ����MySQL���ݿ⣬������Աֻ��Ҫ���ľ����ҵ���߼�ʵ�֣����¸������ݿ⣬Ҳ�������ҵ���߼����룬ֻ��Ҫ���ļ򵥵����ݿ����ü��ɡ���֮������Ϊ������Ա�����ݿ�Ĳ����ṩ�˼򵥸�Ч�Ĳ����ӿڣ����Լ������߿���Ч�ʡ�

ʵ��㣺�����ҪΪORM������ݿ���Ӧ��ʵ���࣬Ϊҵ���߼����Ӧ�ò����

ҵ���߼��㣺�����ǿ�����Ա��Ҫ��д�㣬ͨ���������ݲִ���������ݿ⣬��ΪӦ�ò��ṩ����Ľӿڣ�������������ҵ���߼�������˵����Ϊ���ӵ�һ�㡣

Ӧ�ò㣺�����ڱ�����б�����ʽΪASP.NET
MVC��վ����ʵҲ���Է�ָ����ı�����ʽ������̨����Windows�������WinForm����WPF����ȵȡ�����Ϊ�����Ӧ�ã�����ϵͳ���ܵ�ʵ�֡�

### ������ʩ��

�˲�Ϊ��ײ㣬����Ϊ�������в������Ҫ�ṩ����Ŀ��������ĸ�����⣬��ҪΪ���¼�����⣺

1.  ��չ������

����C\#���﷨�ǣ�����Ӣ���������ѧ�ұ˵á�Լ�������Peter J.
Landin��������һ�����ָ�������������ӵ�ĳ���﷨�������﷨�����ԵĹ��ܲ�û��Ӱ�죬���Ǹ��������Աʹ�ã���������������չ�Զ��巽��������������Ա��ʹ�õ�ʱ��Ϳ���ʮ�ֵķ��㣬���ܼ����ظ��Ĵ������ܼӿ쿪��Ч�ʡ���������������������ࣺ

Object��չ��Object��������Ļ��ࡣ����ǰ������ݽ����У�����JSON��ѡ����˶���JSON���л��뷴���л���ʹ�þ�ʮ�ֵ�Ƶ����ͨ����Object��չToJson�������Ϳ��Խ����ݶ���ֱ��תΪ��Ӧ��JSON�ַ������ܹ�����ļ�JSON���л�����Ҫ�Ĵ��롣

Byte��չ��Byte�����ֽڣ�һ���ֽ���8������λ��ʮ������ֵ��Χ��0-255������Byte���������ֱ�Ӷ�Ӧ�ģ����������һ�����ݶ��Ƕ����ƣ����Թ���Byte��������������֮���ת�����Ե���Ϊ��Ҫ����дByte��ص���չ�����ܹ�����Byte��ʹ�á����磬��չ��Byte����תΪ16�����ַ����ķ������ܹ����ֽ�����ֱ��תΪ��Ӧ��16�����ַ����������������ķ�չҲʮ�ֵ�Ѹ�٣��������������У��ؼ��ǽ�����Ӳ��֮���ͨ�ţ���������Ӳ��������һ�㶼���ߣ������Ӳ��֮���ͨ�Ŵ�����ֽ�Ϊ��λ����������£�ʹ�ø���չ�����Ϳ�����߿���Ч�ʡ�

Expression��չ��Expression�������ʽ������LINQ��ѯ�о���ʹ�á����ճ�ʹ����,Whereɸѡ�������õ����ģ����Ǵ����������Ա����ʹ����ԭʼ��Whereɸѡ����ɸѡ�������࣬ɸѡ�����临�ӵ�ʱ��ԭʼ��Where��ȻҲ����ʤ�Σ����Ǿͻᵼ�´����ظ�����������Źۣ���ʱ����ΪExpression\<Func\<T,
bool\>\>����չAnd��Or����������And�ǡ��롱������Or�ǡ��򡱲����������Ϳ��Խ����ɸѡ����ƴ����һ��ʮ�ֵ�ʵ�á�

IQueryable\<T\>��չ��IQueryable\<T\>���ṩ����ض�����Դ��������������δδ֪��������ѯ�Ĺ��ܽӿڣ�����EntityFramework�з�������Ҫ�����á����磬�ں�̨����ϵͳ�У����ݱ���ʹ����Ϊ�ձ飬ǰ�����̨����������ʱ���������Ҫ���¼�����������ǰ����ҳ�롢ÿҳ��¼�������������������ͣ���Щ������ÿ�����������������ж���Ҫ������ʱ��ͨ����IQueryable\<T\>��չGetPagination\<T\>������ֻ��Ҫ�����ҳ�������Ϳ��Ի�ȡ��������ݱ�����ݣ�ʮ�ֵķ����Ч��

1.  ���߰�����

��Ҫ�ṩ�˳��õ�һЩ�����࣬�����������ڣ�

Office�칫�ĵ����뵼�������ࣺ�����������ǻ�����ʶ����ǿ���Լ�����ҵ�԰칫ģʽ����Ĳ����������ִ�������Ϣ�����貽���ļӿ죬��ֽ���칫�Ѿ��ɸ�����Ӧ�õ������ҵ�����У��칫�У����ְ칫�ļ���������Excel�ļ���Word�ļ�������Ҫ�����뵼��������C\#����Excel��Word�ļ������򵥣����������ſ����ߣ��ɴˣ�������ṩ��Office�ĵ����������࣬��װ���˶԰칫�ĵ��ĳ��ò������ܹ����Ϳ����Ѷȣ���߿���Ч�ʡ�

HTTP����ģ������ࣺ�ڴ�ͳ��վ�����У�һ�㶼��ǰ����������̨�������󣬵��ǣ����ڵ�ϵͳ��ϵͳ֮��ĺ���Խ��Խ���ܣ�������Ҫ������˷������󣬼���Ҫ���ģ��HTTP���󣬵���дһ��������HTTP���󲢲�����ô���ף���˱�����ṩHTTP��������࣬������Աֻ��Ҫ������Ҫ�����URL��ַ������������HTTP���������ʹ�������򵥸�Ч���ܹ��������߿���Ч�ʡ�

1.  �������������

���ִ���ϵͳ�����У�����ҵ����������ϵͳ���ܾ���������Ҫ��Ҫ�ﵽ����Ҫ��һ������Բ��ø��õ�Ӳ�������ǳɱ��ϸߣ�����һ�������ʹ�û��棬��Чʹ�û����ܹ�����������벢����������ɱ��ϵͣ��Ǿ�������û�����ѡ��

.NET
Framework����ṩ��ϵͳ���棬��Ȼʹ�ü򵥷��㣬���ǲ�֧�ֲַ�ʽ����˴��ѡ������Redis��Memcached���棬���ǲ�ͬ�Ļ���Ϊ�������ṩ�Ľӿڲ�һ������ʹ�ò�ͬ�Ļ���ʱ������Ա����Ҫȥѧϰ��Ļ�������ӿڣ�ʮ�ֵ��鷳��Ϊ���������⣬������ṩ�˻�����������ࡣ������������ཫ������Ĳ���������ɲ����ӿڣ���ӻ��桢ɾ�����桢���û������ʱ�䣬Ȼ������Redis��ϵͳ����ʵ�ֳ���ӿڣ���ʹ�û���ʱ����ʹ��ͬ���Ĳ����ӿڲ�����ͬ�Ļ��棬�ܹ����Ϳ�����Աѧϰ�ɱ�����߿���Ч�ʡ�

1.  ���ݿ����������

����ʲô��վ��ֻҪ��Ҫ�����ݽ��в�������ô����벻�����ݿ⡣���ݿ�Ŀǰʹ�����ľ��������ϵ�����ݿ⣺SQLServer��MySQL��Oracle���������ݿ���Ҫһϵ�еĳ���������Ҫ�������ݿ����Ӷ��󣬽����Ŵ����ݿ⣬��δ������ݿ�������Ȼ��ִ��������õ����ݽ������ÿ�η������ݿⶼҪдһ����Щ���̣���ô���Ἣ����谭����Ч�ʣ���ˣ�������ṩ�����ݿ���������࣬�����ݿ��������Ҫ�����̷�װ��������Աֻ��Ҫ���ľ����SQL���ı�д���ɣ�����֧�������ϵ�����ݿ⣬�ʺϲ�ͬ�Ŀ�����Աʹ�á�

### ���ݲִ���

�ں�˿����У����ݿ��������Ƶ���ģ�ÿһ����˿�����Ա�����ٶ���Ӵ����������ٿ�����Աÿ��Ĺ������������ݿ�򽻵������Կɼ����ݿ�����Ƕ�ô����Ҫ�������ڿ����Ĺ����У��������������Աֻ���Ա�дSQL���ķ�ʽ�������ݿ⣬���ַ�ʽ�ǲ������ݿ��������ԭʼ�ķ�ʽ���򵥸�Ч�������ڱ�дSQL���Ĺ����У������������������д���󣬾ͻ����һ�����󣺿�����Ա�����һ��SQL�����DEBUG������ÿ�ζ���Ҫ������Ա�Լ�ȥ��дSQL��䣬�俪��Ч�ʼ��͡����¿�����Ա�㹻��ɫ���ܹ���֤��д��SQL���ϵ͵ĳ����ʣ����ǣ���ͬ�����ݿ�����Ҫ��SQL��仹���в���ģ������Ҫ������Աѧϰ��ͬ�����ݿ�SQL�﷨�����ѧϰ�ɱ�����������Ŀ����������������������ݿ���������ʱ����Ҫ���Ѵ����ľ���ȥ�����޸�SQL��䡣

�ڱ���ܵ����ݲִ����У��������⼴��ӭ�ж��⡣���ݲִ��㣬��ͬ�ڴ�ͳ����ܹ��е����ݲ㣬����ļ̳й�ϵͼ����ͼ��ʾ��ͼ6-1����

![���ݲִ�����ͼ](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/7c6b996db3f7d50c53e6a15585ad9357.png)

ͼ6-1 ���ݲִ���ͼ

����ͼ��ʾ�����ȶ��������ݲ����ӿ�IRepository,�ýӿڰ���������ɾ���ġ��顢������Ƶ����ݿⳣ�ú��Ĳ������ܹ���������ݿ�ĳ��ò�����DbRepository��ʵ����IRepository�ӿڣ���Ҫ��ORM���Entity
FrameworkΪ��������װʵ���˴󲿷�IRepository����Ĳ�����SqlServerRepository��MySqlRepository��PostgreSqlRepository�ֱ�ʵ�־������ݿ��Ӧ�����ݲִ������Ҽ̳���ͬһ�����ݲ����ӿ�IRepository������ھ����ʹ���ϣ�����ʵ����ͬһ�������������ʲ�ͬ�����ݿ⣬��������Ҫ�������ݿ�����ʱ�����ñ���ܿ�����ϵͳ�ܹ����Ĵ�����������У���һ���ܹ�����Ľ�����������ɱ���������Entity
FrameworkΪ���ģ�����Ҫ��дSQL�����ܹ���ɾ��󲿷ֵ����ݿ�������ټ��ϼ���LINQ��ϣ����׽�������Ա��SQL����н�ų������ÿ�����Ա�ܹ�����רע��ҵ���߼���ʵ�֣��ܹ����������������Ч�ʡ�

IRepository�������£�

using System;

using System.Collections.Generic;

using System.Data;

using System.Data.Common;

using System.Data.Entity;

using System.Linq;

using System.Linq.Expressions;

namespace Coldairarrow.DataRepository

{

public interface IRepository

{

\#region ���ݿ�������ط���

DbContext GetDbContext();

\#endregion

\#region �����ύ

/// \<summary\>

/// ��ʼ��������

/// ע��:��Ҫʹ�ÿ������,��ʹ��DistributedTransaction

/// \</summary\>

void BeginTransaction();

bool EndTransaction();

\#endregion

\#region ��������

void Insert\<T\>(T entity) where T : class, new();

void Insert\<T\>(List\<T\> entities) where T : class, new();

void BulkInsert\<T\>(List\<T\> entities) where T : class, new();

\#endregion

\#region ɾ������

void DeleteAll\<T\>() where T : class, new();

void Delete\<T\>(string key) where T : class, new();

void Delete\<T\>(List\<string\> keys) where T : class, new();

void Delete\<T\>(T entity) where T : class, new();

void Delete\<T\>(List\<T\> entities) where T : class, new();

void Delete\<T\>(Expression\<Func\<T, bool\>\> condition) where T : class,
new();

\#endregion

\#region ��������

void Update\<T\>(T entity) where T : class, new();

void Update\<T\>(List\<T\> entities) where T : class, new();

void UpdateAny\<T\>(T entity, List\<string\> properties) where T : class, new();

void UpdateAny\<T\>(List\<T\> entities, List\<string\> properties) where T :
class, new();

\#endregion

\#region ��ѯ����

T GetEntity\<T\>(object keyValue) where T : class, new();

List\<T\> GetList\<T\>() where T : class, new();

IQueryable\<T\> GetIQueryable\<T\>() where T : class, new();

DataTable GetDataTableWithSql(string sql);

DataTable GetDataTableWithSql(string sql, List\<DbParameter\> parameters);

List\<T\> GetListBySql\<T\>(string sqlStr) where T : class, new();

List\<T\> GetListBySql\<T\>(string sqlStr, List\<DbParameter\> parameters) where
T : class, new();

\#endregion

\#region ִ��Sql���

void ExecuteSql(string sql);

void ExecuteSql(string sql, List\<DbParameter\> parameters);

\#endregion

}

}

### ����ʵ���

���ڿ����Ҫ������Entity
Framework��ΪORM��ܣ����������ݿ�ʵ��ӳ��ز����٣���Ҫ�����ݿ���ÿ�ű�ӳ�䵽���У�����һ�ű�һ���ࡣ��Щʵ���༴�ܹ���Ϊ���ݿ�����е�ʵ�壬���ܹ���ΪDTO(Data
Transfer
Object)������Щʵ���໮��Ϊ������һ�㣬�ܹ������ʵ��Ĺ������ڿ�����ά����

### ҵ���߼���

��������˿����У�ҵ���߼��Ĵ�������ӵģ���Ϊ�Ӽ����Ƕ��������ܶ༼�����ܹ�ʵ�ִ��븴�ã��������ظ������ӣ������������ظ�����һ���Ѿ����ڵĻ����������߱��������Ż���������ֻҪ��ʹ���˾��ܹ�����Ͷ�������У���Ȼ�������Դ������ʵ�ִ������ã�����ѧϰ�ɱ������ǲ�ͬ��ϵͳ��ҵ���߼�ͨ���ǲ��ɸ��Ƶģ���˿�����Ա���Բ����ľ������ݲִ���ʵ�ּ��������ǲ��ò����ľ���ҵ���߼���ʵ�֣���Ȼҵ���߼��޷���������ô���ӣ���ô��Ƴ������ҵ���߼��ܹ����ӿ쿪��Ч�ʾ��Ե���Ϊ��Ҫ��

����ܽ�ҵ���߼�����һ�㣬����ļ̳й�ϵ����ͼ��ͼ6-2����ʾ��

![ҵ���߼�����ͼ](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/2440b35e97d7597972cc92a7be9e56f2.png)

ͼ6-2 ҵ���߲��ͼ

����ͼ��ʾ�����ȶ�����һ��ҵ���߼�����BaseBusiness\<T\>���û���ʵ�������е������ݲִ��ķ�������������ҵ�����඼��Ҫ�̳��Ի���BaseBusiness\<T\>�����з���TΪ���ݿ�ʵ�壬һ��Ĭ�ϲ������ű�����ʵ���������������ʮ�ֵ��ձ飬�����BaseBusiness���ṩ��Service���ԣ�������ΪIRepository���ͣ���˿��Բ������ͽӿڣ����벻ͬ��ʵ�����ͼ��ɶ�Ӧ�������Ĳ������ʶ�֧��������������㿪����Ա�������ݿ⡣���໹�ṩ��ͨ��ҵ���߼��������ݣ�Success��Error�ֱ��Ӧ�ɹ����󷵻غ�ʧ�����󷵻أ�ͳһ���ݸ�ʽ������ǰ��˿����Խӡ�

### Ӧ��չʾ��

���Ҳ���Գ�֮ΪӦ�ò㣬����Ĳ������ʽ������⣬����һ�㸺�������ĿӦ�õ�ʵʩ���������ʹ�ÿ���̨����Windows�������WinForm����WCF����ȵ�,�ڱ���Ŀ��ʹ����ASP.NET
MVC��վ��Ŀ������幦�ܵ�ʵ�֡�

AOP��Aspect Oriented
Programming��ʹ�ã�AOP����������Ƭ��̣�����AOP�ܹ���ϵͳ�������ֽ��и��룬�Ӷ�����ģ��֮�����϶ȣ���߳�������ԣ�ͬʱ��߿���Ч�ʡ����������Ҫʹ��������AOP��

����Ա��¼У��CheckLoginAttribute���ں�̨����ϵͳ�У�����Աֻ�е�¼����ܹ�������ز�����һ��ͨ��Session����¼����Ա��¼��Ϣ�����ֱ�Ӿ�����ÿһ�������ж���Ҫ�ж�һ�����Ա�Ƿ��¼�������ɽ��ᵼ�ºܶ���ظ����룬��ʱ��ͨ������½У����Ϊһ�����ԣ�ֻ��Ҫ����Ҫ��¼�Ŀ������򷽷�����Ӹ����Լ�����ɹ���Ա��¼У�飬�������ܹ����ٴ������ظ����룬�ӿ쿪��Ч�ʡ�

ǩ��У��CheckSignAttribute������˽ӿ���Ҫ���ⲿϵͳ����ʱ�������Խӿڷ��ʽ������ƣ���ô�ͻ����ٶ������󹥻��ķ��գ�����Ӱ��ϵͳ���ܣ�������ϵͳ̱�������ݱ����⴮�ģ���ʱ����֤�ӿڵİ�ȫ�Ծ�ʮ�ֹؼ�����֤�ӿڵİ�ȫ�ԣ���Ҫ���ǰ���һ����ǩ���㷨���������ߴ���Ĳ�������ǩ��У�飬ֻ��ͨ�����ܹ��������ʣ�ԭʼ����������ÿ��������ȥ����ǩ��У�飬��ͬ���ᵼ�´������ظ����룬��ʱͨ������ǩ��У�����ԣ�ֻ��Ҫ����Ҫǩ��У��Ŀ������򷽷��м������Լ��ɣ�ʹ�ü򵥷��㣬����Ч��Ҳ�ߡ�

Ӧ�ò㻹����ͼ��ʹ����ͨ�ò���ģ�壬��ͳһ�˴���淶���ټ�����JQuery�Լ�һЩ�������õ�JS��⣬��LayuiΪ��Ҫǰ��UI��ܣ�������ͳһ������Ч�ʸߡ�

���ܼܹ�
--------

### ȫ������

��01.Coldairarrow.Util�е�GlobalSwitch���У������˸�������������RunModel��Ҫ�ص��עһ�£���RunModel==RunModel.LocalTest����ϵͳ��ֱ��������¼��Ĭ��ʹ��Admin��������Ա��¼�����������뿴ע�͡�

### ���ٿ���

ʹ�ô˹�����ȷ��GlobalSwitch.RunModel= RunModel.LocalTest

�˹���Ϊ����ܵĺ��Ĺ��ܣ��ܹ��Զ����������Ŀ����д��룬����ʹ�����£�

��ѡ��Ҫ�����ݿ�Դ����Ϊ���������Ǹ������ݿ�������ɵġ�

�˵�������=\>���ٿ���=\>���ݿ����ӹ���

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/e3ca030146a14590952fef3174d61302.png)

���б���û��Ŀ������Դ����������ݿ�����

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/a5fd19bf7f4b513e6d1dbdad05b92c0d.png)

�����������������ַ��������ݿ����ͼ��ɡ������ɺ󼴿ɿ��������ַ�����Ϣ��

�������ݿ�����֮�󣬼��ɽ��д������ɡ�

�˵�������=\>���ٿ���=\>��������

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/765261eff0314966d87140c2f89c9f46.png)

ѡ�����ݿ⣬Ȼ��ѡ��Ҫ���ɴ�������ݿ��������ɴ���ᵯ������ѡ�������ʱֻ�ܹ�ѡDev_Project�������ȫ��ϵͳ��������Ҫ��ѡ������ᱻ���ǣ������쳣���빴ѡ�Լ���ҵ���������ɣ���

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/7095c8e805cf72adce349ff6cbeaeb80.png)

����ѡ���п���ѡ����Ҫ���ɵ����ͣ�����Ĭ������ʵ��㡢ҵ���߼��㡢����������ͼ��

���������ӦMVC�е�Areas���밴�����루���

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/bc55f356701b11591f2f680b32e1b267.png)

����ʾ����дProjectManage��������ɰ�ť��������ɴ������ɡ����ɺ�Ĵ�������Ŀ��������У��������ļ�����������Ŀ

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/a92dafe0e3fbb15cf31d00aea13bc647.png)

Ĭ�����ɺ���ļ������صģ���Ҫ�����ʾ�����ļ���ť�����ɿ������ɺ�����ļ�

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/39917f16adc28c948879bb28e3095517.png)

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/71eab7be91b21eb5831a880188115914.png)

�Ҽ��µ��ļ��У���������Ŀ��

�����������ɵĴ��룬���Բ������µĲ˵�

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/1c7a04caf98924562b98b5d19af5e8bb.png)

����ͼ����Web��Ŀ�е�Config/SystemMenu.config�����ò˵���ģ��ԭ�в˵����ɣ�����url��ָҳ���·����Permission��ָ����Ҫ���ʴ˲˵���Ҫ��Ȩ�ޣ���ӦȨ�����ã�����û�д�Ȩ�ޣ���˵�Ҳ�в�����ʾ�˲˵����޸���ɺ����±������ɣ�Ȩ�����ģ������˻��棬�������ɻ��建�棩���������м��ɿ����µ���Ŀ�˵����£�

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/28096e3417af971be7b6a5b41477bc78.png)

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/3a92ef1ce96151a0881bd8e0887b574c.png)

�����������ɹ��̣������д���뼴�����һ�ű��CRUD����Ȼ��Ҫ���ݾ���ҵ���н�����Ӧ���޸ģ�����ʾ�����ֶαȽ��٣����ǵ�һ�ű���ֶκܶ�ʱ����ô�˹����ܹ�������Ч����߼������Ρ�

### ����Ա��¼

��Ҫʹ�õ�¼���ܣ��뽫GlobalSwitch�е�RunModel��ΪRunModel.Publish

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/3ffa748dc16b17b9cc33450b4218b700.png)

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/caa00d3fad33ffb89ceafc917db49a43.png)

Ĭ�ϳ�������Ա�˺�Ϊ��Admin

����Ϊ��123456

### ϵͳ�û�����

����ϵͳ��¼���û�

�˵���ϵͳ=\>�û���������ҳ��

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/71270e03db7afefb8091002eed1d87e8.png)

����Ҳ�����Ȩ�ޣ����������û�Ȩ�ޣ������\<Ȩ�޹���\>ģ��

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/fffb02499695a127cc370c43e32c4b02.png)

����Ȩ��������ü�Ȩ�޹���ģ��

### ϵͳ��ɫ����

����ϵͳ��ɫ����ɫ��Ȩ�޵����壬��������ɫ������Ȩ�޹���

�˵���ϵͳ=\>��ɫ����

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/6c34c2cd0fc95db019125a3b5b171d62.png)

�����п������ý�ɫ��Ȩ�ޣ������\<Ȩ�޹���\>ģ��

### Ȩ�޹���

һ������£���̨����ϵͳ���ٻ��漰Ȩ�޹�����˱�����ṩ��һ������Ч������Ȩ�޹���ϵͳ��

���ȣ�Ȩ�޷�Ϊ���֣�������Ȩ�޺�����Ȩ�ޣ����в���Ȩ�ޱ���ϵͳ�û�Ȩ�޺�AppIdȨ�ޣ�ϵͳ�û�Ȩ�޾���ָ�����û��߱���ЩȨ�ޣ����������ṩApi�ӿ�ʱ��Ϊ�˱�֤�ӿڵİ�ȫ�ԣ���������ɺ��ԣ���ͨ�����ṩ�ӿ�ǩ���㷨������AppId��AppSecret�Ǳر��ģ�ͨ����AppId����Ȩ�ޣ����ɿ��ƽӿڵ�Ȩ�ޡ�����Ȩ�ޱȽϸ��ӣ������ô�SQL��ʽ����ô����Ӹ��ӣ������ȫ�̲���EF��ΪORM��ܣ�ͨ����IQueryable\<T\>���й��ˣ������������Ȩ�޿��ơ�

�û�Ȩ�ޣ�����ÿ���û������ö�Ӧ��Ȩ�ޣ���ô������������ʮ�־޴�ģ���������˽�ɫ�ĸ����ɫ��Ȩ�޵ļ������壬��ô���ڴ˽�ɫ���û��ͼ̳��˽�ɫ��Ȩ�ޣ���ȻĳЩ�����û���Ҫӵ���Լ��Ĳ����ڽ�ɫ������Ȩ�ޣ���������û�ӵ�е�Ȩ�޾����Լ���Ȩ�޺�������ɫȨ�޵Ĳ�����

Ȩ��ʹ�ã�

Ȩ�޶��壺

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/ca876054eda95934a0d1c3b581f6ff06.png)

����ͼ����Permission.config�ж����˸���Ȩ��

Ȩ�����ã�

��ϵͳ�û������ϵͳ��ɫ�����п��������û��ͽ�ɫ��Ȩ�ޣ�����Ҫ��Ȩ�޹�ѡ���ɡ�

Ȩ��ʹ�ã�

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/4a9b9a5511d2f2ef73e8963acc6013cd.png)

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/3deabc09a2e23fe7b6505c3c5ee33d1d.png)

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/2d6718babf21f8ece07bd1bb43c327df.png)

����ͼ��ʾ������Ҫ����Ȩ�޵�ҳ���У����÷�����PermissionManage.OperatorHasPermissionValue("sysuser.manage")

����������жϲ������û��Ƿ���sysuser.manageȨ��ֵ������sysuser��ָPermission.config�ж����module��value���ԣ�manage��ָpermission�е�value���ԣ���.���Ӽ�������Ȩ��ֵ��

����ϸ��ʹ�÷�ʽ����ο�Դ���롣

### �ӿ���Կ����

�˵���ϵͳ=\>�ӿ���Կ����

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/a85503af5276b0fcc00babe82f8d27bf.png)

### ϵͳ��־

�˵���ϵͳ=\>ϵͳ��־

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/9743e1ed093c95b2db4a5b2f94468bb7.png)

��������
========

��ν��������ѯ��
------------------

���ʹ��EF+LINQ��������������������ڶ�IQueryable\<T\>��ʹ�ã����������EF+LINQ����ؽ̡̳�

ʾ������ͼ��

![D:\\�ĵ�\\Tencent Files\\862520575\\Image\\C2C\\KYV\$W\`4O717F2Y37P)RQMEL.png](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/743de14d757d5122ff90d19d7374a39b.png)

![D:\\�ĵ�\\Tencent Files\\862520575\\Image\\C2C\\%7ZU5J_S5BTRFI91AF2Z81E.png](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/77dc5839af208d8b34cd5f8fb7737866.png)

����л����ݿ⣿
----------------

��01.Coldairarrow.Util��Ŀ�е�GlobalSwitch����DatabaseType��Ϊ��Ҫ�ļ��ɣ���Ӧ�����ݿ������ַ�����ȻҲҪ��Ϊ��Ӧ���ݿ��

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/12dadb7b8d1e1c3b03346a2bab14a783.png)

���ʹ�ñ�����ݿ⣨����Ĭ�ϵ�ϵͳ���ݿ⣩
------------------------------------------

�ھ����Business������д����BaseBusiness�Ĺ��캯�����ɣ������Լ���������д��Ӧ�Ĺ��캯��,ͬʱ��Ҫȷ�����ݿ������ַ��������

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/26c3abad7e29e9fd6e9bc04ac7b5644a.png)

![](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/595213325962326dacfdb657ae9a8c86.png)

����
====

��ӭʹ�ñ���ܣ������ò��������

![https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1536642906843&di=1a0e84336a3b4c068deab1a2d2fc342d&imgtype=0&src=http%3A%2F%2Fwww.ghost64.com%2Fqqtupian%2FzixunImg%2Flocal%2F2017%2F05%2F25%2F14956980289595.jpg](https://raw.githubusercontent.com/Coldairarrow/UploadFiles/master/Colder.Fx.Net.AdminLTE/04abaa3d37fa01b4c4058c8163aab6a8.jpg)

Github:<https://github.com/Coldairarrow>����Statrt

����԰��<https://www.cnblogs.com/coldairarrow/>

QQȺ��373144077

���˽����������ٿ�����ܲ���������ά����ϣ���ܹ���������λ

�������κ��������Ҫ����֧�֣�����ϵ�ҡ�

\---------------------ѧϰ����ֹ���������������ޣ������������-----------------------
