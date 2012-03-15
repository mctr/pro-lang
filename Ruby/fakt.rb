#/usr/bin/ruby
# coding: utf-8
def fakt(sayi)
	if sayi == 0 or sayi == 1
		1
	elsif sayi > 0
		sayi * fakt(sayi - 1)
	elsif sayi < 0
		"\nNegatif tamsayilarin faktoriyel hesaplamasi yapilamaz.."
	end
end
puts fakt(6)
