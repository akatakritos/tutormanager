-- report of driving log
select s.date, c.name, r.miles from sessions s join clients c on s.client=c.clientid join routes r on s.route=r.routeid order by s.date

-- total miles driven
select sum(routes.miles) from sessions join routes on sessions.route=routes.routeid

-- Sum of hours by client
select c.Name, sum (s.Duration) from Sessions s join clients c on s.client=c.clientid group by c.name

-- paychecks log
select Date, Amount, TaxRate, TaxPaid, Net from Paychecks order by Date