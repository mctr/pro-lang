#! usr/bin/ruby
#encoding : utf - 8

def fact(n)
	if n == 0
		1
	else
		(n * fact(n - 1))
	end
end
puts fact(4)

#~ print fact(ARGV[0].to_i), "\n" // Komut satırından çalıştırmak için bu kod satırı kullanılır 

def fib(n)
	if n < 2
		1
	else
		fib(n - 1) + fib(n - 2)
	end
end

puts fib(5)
