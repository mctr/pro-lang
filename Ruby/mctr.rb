dizim = ["bu", "ne", "la", "mctr"]
say = 0
while say != dizim.length
	index = say
	dizim.each do
		print dizim[index % dizim.length] + " "
		index += 1
	end
	puts "\n"
	say += 1
end
