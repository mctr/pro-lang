#! usr/bin/ruby
# coding: utf-8
def sqrt_sum(sayi)
	sum = 0
	(1..sayi).each do |i|
		sum += i * i
	end
	sum
end

puts sqrt_sum(11)
