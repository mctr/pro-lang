#! usr/bin/ruby
#-*- encoding :utf-8 -*-

def main()
	print "Lütfen bir sayma sayısı giriniz :"
	sayi = gets.chomp
	
	if sayi.to_i == 0
		print " \n Bu bir sayma sayısı dagil! "
		main()
	else print "\n girdiginiz sayma sayısı ==>\t" ,sayi.to_i
	end
end

if __FILE__ == $0
  main()
end
