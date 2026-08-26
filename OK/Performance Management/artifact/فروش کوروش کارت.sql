-- OKDC30027\node
-- OKKouroshCard

use OKKouroshCard
go
DECLARE @Month INT,
        @Day INT

SET @Month = FORMAT(GETDATE(),'MM','fa-ir')
SET @Day = FORMAT(GETDATE(),'dd','fa-ir') 

SELECT @Day N'روز ماه'
 
SELECT CASE 
			WHEN @Month - 1 >= 1 AND @Month - 1 <= 6 
			THEN (@Month - 1) * 31
			WHEN (@Month - 1) >= 7 AND (@Month - 1) <= 11 
			THEN (@Month - 1 - 6) * 30 + ( 6 * 31)
			ELSE 0 
       END + @Day [روز سال]

drop table if exists #YearsFirstDay
select *
into #YearsFirstDay
from
(
	values
	(1400,'2021-03-21'),
	(1401,'2022-03-21'),
	(1402,'2023-03-21'),
	(1403,'2024-03-20'),
	(1404,'2025-03-21'),
	(1405,'2026-03-21'),
	(1406,'2027-03-21'),
	(1407,'2028-03-20'),
	(1408,'2029-03-20'),
	(1409,'2030-03-21'),
	(1410,'2031-03-21')
) YearsFirstDay (PersianYear,FirstDate)

drop table if exists #YearsMonthFirstDay
select *
into #YearsMonthFirstDay
from
(
	values
	(140301,'2024-03-20','2024-04-19'),
	(140302,'2024-04-20','2024-05-20'),
	(140303,'2024-05-21','2024-06-20'),
	(140304,'2024-06-21','2024-07-21'),
	(140305,'2024-07-22','2024-08-21'),
	(140306,'2024-08-22','2024-09-21'),
	(140307,'2024-09-22','2024-10-21'),
	(140308,'2024-10-22','2024-11-20'),
	(140309,'2024-11-21','2024-12-20'),
	(140310,'2024-12-21','2025-01-19'),
	(140311,'2025-01-20','2025-02-18'),
	(140312,'2025-02-19','2025-03-20'),
	(140401,'2025-03-21','2025-04-20'),
	(140402,'2025-04-21','2025-05-21'),
	(140403,'2025-05-22','2025-06-21'),
	(140404,'2025-06-22','2025-07-22'),
	(140405,'2025-07-23','2025-08-22'),
	(140406,'2025-08-23','2025-09-22'),
	(140407,'2025-09-23','2025-10-22'),
	(140408,'2025-10-23','2025-11-21'),
	(140409,'2025-11-22','2025-12-21'),
	(140410,'2025-12-22','2026-01-20'),
	(140411,'2026-01-21','2026-02-19'),
	(140412,'2026-02-20','2026-03-20'),
	(140501,'2026-03-21','2026-04-20'),
	(140502,'2026-04-21','2026-05-21'),
	(140503,'2026-05-22','2026-06-21'),
	(140504,'2026-06-22','2026-07-22'),
	(140505,'2026-07-23','2026-08-22'),
	(140506,'2026-08-23','2026-09-22'),
	(140507,'2026-09-23','2026-10-22'),
	(140508,'2026-10-23','2026-11-21'),
	(140509,'2026-11-22','2026-12-21'),
	(140510,'2026-12-22','2027-01-20'),
	(140511,'2027-01-21','2027-02-19'),
	(140512,'2027-02-20','2027-03-20')
) YearsMonthFirstDay (YearMonth,FirstDay,LastDay)

DECLARE @Today DATETIME,
        @Current_Month INT,
		@Prev_Month INT,
		@Current_Month_First_Day DATETIME,
		@Prev_Month_First_Day DATETIME,
		@Prev_Month_Last_Day DATETIME,
		@Prev_Year_FirstDay DATETIME,
		@Current_Year_FirstDay DATETIME,
		@Prev_Year int,
		@Current_Year int

SELECT @Today = GETDATE(),
       @Current_Month = FORMAT(GETDATE(),'yyyyMM','fa-ir'),  
       @Prev_Month = FORMAT(DATEADD(MONTH,-1,GETDATE()),'yyyyMM','fa-ir'),
	   @Current_Year = FORMAT(GETDATE(),'yyyy','fa-ir'),
	   @Prev_Year = FORMAT(DATEADD(YEAR,-1,GETDATE()),'yyyy','fa-ir')

select @Current_Year_FirstDay = FirstDate     --  تاریخ اولین روز سال جاری 
from #YearsFirstDay 
where PersianYear = @Current_Year   

select @Prev_Year_FirstDay = FirstDate        --  تاریخ اولین روز سال قبل 
from #YearsFirstDay 
where PersianYear = @Prev_Year   

select @Prev_Month_First_Day = FirstDay       -- تاریخ اولین روز ماه قبل
from #YearsMonthFirstDay 
where YearMonth = @Prev_Month   

select @Prev_Month_Last_Day = LastDay         -- تاریخ آخرین روز ماه قبل
from #YearsMonthFirstDay 
where YearMonth = @Prev_Month   

select 	@Current_Month_First_Day = FirstDay   -- تاریخ اولین روز ماه جاری
from #YearsMonthFirstDay 
where YearMonth = @Current_Month   

---  Current Year ----

SELECT 
       concat(@Current_Year,'-مناطق') N'حوزه _ دوره',
       (
	     sum(amount) - (  
	                    SELECT sum(amount) 
						FROM [OKKouroshCard].[card].[Requests] r
						join [card].[Customers] c 
						    on r.CustomerId = c.Id
						where r.type  = 10 and
						      r.Active = 1 and
							  r.IsDeleted = 0 and
							  r.IsSent = 1 and
							  c.Region is not null and
							  c.Region != 100 and
							  r.CreatedOn >= @Current_Year_FirstDay 
					    )
		) N'فروش'
FROM [OKKouroshCard].[card].[Requests] r
join [card].[Customers] c 
     on r.CustomerId = c.Id
where 
     r.type  = 9 and
	 r.Active = 1 and
	 r.IsDeleted = 0 and 
	 r.IsSent = 1 and
	 c.Region is not null and
	 c.Region != 100 and
	 r.CreatedOn BETWEEN @Current_Year_FirstDay AND GETDATE() 
UNION
SELECT 
     concat(@Current_Year,'-ستاد'),
	 (
	  sum(amount) - (
	                    SELECT sum(amount) 
						FROM [OKKouroshCard].[card].[Requests] r
						join [card].[Customers] c 
							   on r.CustomerId = c.Id
						where 
							   r.type  = 10 and
							   r.Active = 1 and
							   r.IsDeleted = 0 and
							   r.IsSent = 1 and
							   (c.Region is null or c.Region = 100 ) and
							   r.CreatedOn >= @Current_Year_FirstDay
					 )
	 ) 
FROM [OKKouroshCard].[card].[Requests] r
join [card].[Customers] c 
      on r.CustomerId = c.Id
where 
       r.type  = 9 and
	   r.Active = 1 and
	   r.IsDeleted = 0 and
	   r.IsSent = 1 and
	   (c.Region is null or c.Region = 100 ) and
	   r.CreatedOn BETWEEN @Current_Year_FirstDay AND GETDATE()
UNION

---  Prev Year ----

SELECT 
      concat(@Prev_Year,'-مناطق'),
	  (
	   sum(amount) - (  
	                    SELECT sum(amount) 
						FROM [OKKouroshCard].[card].[Requests] r
						join [card].[Customers] c 
						       on r.CustomerId = c.Id
						where 
						     r.type  = 10 and
							 r.Active = 1 and
							 r.IsDeleted = 0 and
							 r.IsSent = 1 and
							 c.Region is not null and
							 c.Region != 100 and
							 r.CreatedOn between @Prev_Year_FirstDay and GETDATE() - 365
					  )
	   ) 
FROM [OKKouroshCard].[card].[Requests] r
join [card].[Customers] c 
	on r.CustomerId = c.Id
where 
    r.type  = 9 and
	r.Active = 1 and
	r.IsDeleted = 0 and
	r.IsSent = 1 and
	c.Region is not null and
	c.Region != 100 and
	r.CreatedOn between @Prev_Year_FirstDay and GETDATE() - 365
UNION
SELECT 
     concat(@Prev_Year,'-ستاد'),
	 (
	    sum(amount) - 
		              (  
					        SELECT sum(amount) 
							FROM [OKKouroshCard].[card].[Requests] r
							join [card].[Customers] c 
							      on r.CustomerId = c.Id
							where 
							      r.type  = 10 and
								  r.Active = 1 and
								  r.IsDeleted = 0 and
								  r.IsSent = 1 and
								  (c.Region is null or c.Region = 100) and
								  r.CreatedOn between @Prev_Year_FirstDay and GETDATE() - 365
					   )
	  ) 
FROM [OKKouroshCard].[card].[Requests] r
join [card].[Customers] c 
     on r.CustomerId = c.Id
where 
     r.type  = 9 and
	 r.Active = 1 and
	 r.IsDeleted = 0 and
	 r.IsSent = 1 and
	 (c.Region is null or c.Region = 100) and
	 r.CreatedOn between @Prev_Year_FirstDay and GETDATE() - 365
UNION 

---  Current Month ----

SELECT 
      CONCAT(@Current_Month,'-مناطق'),
	  (
	     sum(amount) - 
		              (  
					    SELECT sum(amount) 
						FROM [OKKouroshCard].[card].[Requests] r
						join [card].[Customers] c 
						     on r.CustomerId = c.Id
						where 
						      r.type  = 10 and
							  r.Active = 1 and
							  r.IsDeleted = 0 and
							  r.IsSent = 1 and
							  c.Region is not null and
							  c.Region != 100 and
							  r.CreatedOn between @Current_Month_First_Day and @Today
					 )
	  ) 
FROM [OKKouroshCard].[card].[Requests] r
join [card].[Customers] c 
      on r.CustomerId = c.Id
where 
      r.type  = 9 and
	  r.Active = 1 and
	  r.IsDeleted = 0 and
	  r.IsSent = 1 and
	  c.Region is not null and
	  c.Region != 100 and
	  r.CreatedOn between @Current_Month_First_Day and @Today
UNION
SELECT 
      CONCAT(@Current_Month,'-ستاد'),
	  (
	  sum(amount) -
	              (  
				    SELECT sum(amount) 
					FROM [OKKouroshCard].[card].[Requests] r
					join [card].[Customers] c 
					     on r.CustomerId = c.Id
					where 
					     r.type  = 10 and
						 r.Active = 1 and
						 r.IsDeleted = 0 and
						 r.IsSent = 1 and
						 (c.Region is null or c.Region = 100) and
						 r.CreatedOn between @Current_Month_First_Day and @Today
				  )
	 ) 
FROM [OKKouroshCard].[card].[Requests] r
join [card].[Customers] c 
     on r.CustomerId = c.Id
where 
     r.type  = 9 and
	 r.Active = 1 and
	 r.IsDeleted = 0 and
	 r.IsSent = 1 and
	 (c.Region is null or c.Region = 100) and
	 r.CreatedOn between @Current_Month_First_Day and @Today
UNION 

---  Prev Month ----

SELECT 
      CONCAT(@Prev_Month,'-مناطق'),
	  (
	    sum(amount) - 
		             (
					    SELECT sum(amount) 
						FROM [OKKouroshCard].[card].[Requests] r
						join [card].[Customers] c 
						      on r.CustomerId = c.Id
						where 
						      r.type  = 10 and
							  r.Active = 1 and
							  r.IsDeleted = 0 and
							  r.IsSent = 1 and
							  c.Region is not null and
							  c.Region != 100 and 
							  r.CreatedOn between @Prev_Month_First_Day AND @Prev_Month_Last_Day
					  )
	   ) 
FROM [OKKouroshCard].[card].[Requests] r
join [card].[Customers] c 
      on r.CustomerId = c.Id
where 
      r.type  = 9 and
	  r.Active = 1 and
	  r.IsDeleted = 0 and
	  r.IsSent = 1 and
	  c.Region is not null and
	  c.Region != 100 and
	  r.CreatedOn between @Prev_Month_First_Day AND @Prev_Month_Last_Day
UNION
SELECT 
      CONCAT(@Prev_Month,'-ستاد'),
	        (
			  sum(amount) - 
			              (  
						    SELECT sum(amount)
							FROM [OKKouroshCard].[card].[Requests] r
							join [card].[Customers] c 
							      on r.CustomerId = c.Id
							where 
							      r.type  = 10 and
								  r.Active = 1 and
								  r.IsDeleted = 0 and
								  r.IsSent = 1 and
								  (c.Region is null or c.Region = 100) and
								  r.CreatedOn between @Prev_Month_First_Day AND @Prev_Month_Last_Day
						   )
			) 
FROM [OKKouroshCard].[card].[Requests] r
join [card].[Customers] c 
      on r.CustomerId = c.Id
where 
      r.type  = 9 and
	  r.Active = 1 and
	  r.IsDeleted = 0 and
	  r.IsSent = 1 and
	  (c.Region is null or c.Region = 100) and
	  r.CreatedOn between @Prev_Month_First_Day AND @Prev_Month_Last_Day


-- 3240959538397