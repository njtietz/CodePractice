--https://www.hackerrank.com/challenges/weather-observation-station-2/problem
select format(round(sum(lat_n),2),'#.##'), format(round(sum(long_w),2), '#.##') from station