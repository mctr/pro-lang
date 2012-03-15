#/usr/bin/ruby
# coding: utf-8
def sum(sayi)
	sum = 0
	(1..sayi).each do |i|
		sum += i
	end
	sum
end

puts sum(20)
