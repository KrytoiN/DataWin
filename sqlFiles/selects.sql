select * from sub1;
select * from sub2;
select * from sub3;
select * from KindActivity;
select * from FreqProcess;
select * from proces;
select * from rto;

-- Получение имен таблиц
SHOW COLUMNS FROM proces;

-- Подразделение 1
select idNme as id, nme as 'Подразделение (ур. 1)' from Sub1;
select * from Sub1;

-- Подразделение 2
select sub2.idNme2 as id, sub1.nme as 'Подразделение (ур. 1)', sub2.nme as 'Подразделение (ур. 2)' from sub2 
inner join sub1 on sub2.idNme = sub1.idNme;

select sub2.idNme2, sub1.idNme, sub2.nme from sub2 
inner join sub1 on sub2.idNme = sub1.idNme;

-- Подразделение 3
select sub3.idNme3 as id, sub1.nme as 'Подразделение (ур. 1)', sub2.nme as 'Подразделение (ур. 2)', sub3.nme as 'Подразделение (ур. 3)' from sub3 
inner join sub2 on sub3.idNme2 = sub2.idNme2 
inner join sub1 on sub2.idNme = sub1.idNme;

select sub3.idNme3, sub1.idNme, sub2.idNme2, sub3.nme from sub3 
inner join sub2 on sub3.idNme2 = sub2.idNme2 
inner join sub1 on sub2.idNme = sub1.idNme;

-- Частота процессов
select idFreq as id, nme as 'Частоты процессов' from FreqProcess;
select * from FreqProcess;

-- Вид деятельности
select idActiv as id, nme as 'Вид деятельности' from KindActivity;
select * from KindActivity;

-- Процесс
select proces.idProcess as id, sub1.nme as 'Подразделение (ур. 1)', sub2.nme as 'Подразделение (ур. 2)', sub3.nme as 'Подразделение (ур. 3)', FreqProcess.nme as 'Частота процесса', KindActivity.nme as 'Вид деятельности', OwnerProces.nme as 'Владелец процесса', RtoValues.nme as 'RTO', proces.rtoPrev as 'Предыдущее RTO', Tariffs.nme as 'Тариф', Proces.nme as 'Название процесса' from proces
inner join FreqProcess on proces.idFreq = FreqProcess.idFreq
inner join KindActivity on proces.idActiv = KindActivity.idActiv
inner join OwnerProces on proces.idOwner = OwnerProces.idOwner
inner join RtoValues on proces.idRto = RtoValues.idRto
inner join Tariffs on proces.idTariff = Tariffs.idTariff
inner join sub3 on proces.idNme3 = sub3.idNme3 
inner join sub2 on sub3.idNme2 = sub2.idNme2
inner join sub1 on sub2.idNme = sub1.idNme;

select proces.idProcess, sub1.idNme, sub2.idNme2, sub3.idNme3, FreqProcess.idFreq, KindActivity.idActiv, OwnerProces.idOwner, RtoValues.idRto, proces.rtoPrev, Tariffs.idTariff, Proces.nme from proces
inner join FreqProcess on proces.idFreq = FreqProcess.idFreq
inner join KindActivity on proces.idActiv = KindActivity.idActiv
inner join OwnerProces on proces.idOwner = OwnerProces.idOwner
inner join RtoValues on proces.idRto = RtoValues.idRto
inner join Tariffs on proces.idTariff = Tariffs.idTariff
inner join sub3 on proces.idNme3 = sub3.idNme3 
inner join sub2 on sub3.idNme2 = sub2.idNme2
inner join sub1 on sub2.idNme = sub1.idNme;


-- RТО
select rto.idRto as id, sub1.nme as 'Подразделение (ур. 1)', sub2.nme as 'Подразделение (ур. 2)', sub3.nme as 'Подразделение (ур. 3)', Proces.nme as 'Бизнес-процесс', Rto.timing2Hours as '2 часа', Rto.timing4Hours as '4 часа', Rto.timing8Hours as '8 часов', Rto.timing24Hours as '24 часа', Rto.timing5Days as '5 дней', Rto.timing30Days as '30 дней', Rto.impactDowntime as 'Влияние от простоя', Rto.rto as 'Значение RTO', Rto.rtoPrev as 'Предыдущее значение RTO' from rto
inner join proces on rto.idProcess = proces.idProcess
inner join sub3 on proces.idNme3 = sub3.idNme3
inner join sub2 on sub3.idNme2 = sub2.idNme2
inner join sub1 on sub2.idNme = sub1.idNme;

select rto.idRto, sub1.idNme, sub2.idNme2, sub3.idNme3, Proces.idProcess, Rto.timing2Hours, Rto.timing4Hours, Rto.timing8Hours, Rto.timing24Hours, Rto.timing5Days, Rto.timing30Days, Rto.impactDowntime, Rto.rto, Rto.rtoPrev from rto
inner join proces on rto.idProcess = proces.idProcess
inner join sub3 on proces.idNme3 = sub3.idNme3
inner join sub2 on sub3.idNme2 = sub2.idNme2
inner join sub1 on sub2.idNme = sub1.idNme;

-- Степень зависимости
select idAdd as id, nme as 'Степень зависимости' from Addictions;
select * from Addictions;

-- 1. Описание бизнес процессов  - загрузка процессов (доработать)
select proces.idProcess as id, FreqProcess.nme as 'Частота реализации процесса', KindActivity.nme as 'Вид деятельности', Proces.nme as 'Название процесса' from proces
inner join FreqProcess on proces.idFreq = FreqProcess.idFreq
inner join KindActivity on proces.idActiv = KindActivity.idActiv
where idNme3 = 5;


drop table rto;
