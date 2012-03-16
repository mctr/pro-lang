#! /usr/bin/ruby
# coding: utf-8
sayi = rand(100)
puts "1-100 arasında bir sayiyi tahmin et?(10 deneme hakkin var!!) :"
i = 0
while guess = STDIN.gets and i < 9
	guess.chop!
	i += 1
	if guess == sayi
		puts "Bildin\n"
		break
	else
		puts "Bilemedin! #{10 - i} hakkin kaldi..tekrar tahmin et:\n"
	end
end

