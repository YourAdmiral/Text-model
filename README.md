Automatic-telephone-exchange
EPAM .NET Development: Task 3

Разработать набор классов для моделирования работы автоматический телефонной станции (АТС) и простейшей биллинговой системы. 

Компания-оператор АТС заключает договора с клиентами, присваивает им абонентские номера, предоставляет порты для подключения абонентских терминалов и выдаёт каждому абоненту терминал (телефон). 
Каждый терминал соответствует только одному номеру. 
Абонент может самостоятельно отключать/подключать телефон к порту станции (станция умеет отслеживать изменения состояния порта – отключен, подключен, звонок, и т.п.).
Абоненты могут звонить друг другу только пределах станции. 
Звонки платные, для всех абонентов применяется один тарифный план. 

Абонент может просмотреть детализированный отчет по звонкам (продолжительность/стоимость/абонент) как минимум за предыдущий месяц, выполнять фильтрацию по дате звонка, сумме, абоненту. 

Что должно присутствовать: 
- code style	5
- ООП (объектная модель для всех сущностей c разумной декомпозицией) 	15
- работа с событиями (подписка, отписка, взаимодействие терминалов со станцией на основе событийной модели) 	50
- Биллинговая система: учет звонков, фильтрация, агрегация	15
- разработка UI не требуется. достаточно консольного приложения, которое должно демонстрировать типичные сценарии использования объектов чтобы моделировать деятельность АТС и биллинговой системы (соединение абонентов с учетом состояния порта, заключение договора, подключение/отключение терминала, вывод истории звонков для каждого абонента)	15

