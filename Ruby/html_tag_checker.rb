#! usr/bin/ruby
#-*- coding:utf-8 -*-

def html_filtrele(html_file)
	liste = []
	yeni = ""
	file = File.new(html_file, "r")
	state = true
	s = true
	while (line = file.gets)
		line.each_char do |i|
			if i == ">"
				s = false
				state = true
			end
			if state == false
				yeni += i
			end
			if i == "<"
				state = false
			end
			if s == false
				liste.push(yeni)
				yeni = ""
				s = true
			end
		end
	end
	return liste
end
 
def matches open, close
	return open == close[1..close.length]
end
 
 
def html_tag_checker(file_html)
	tags = html_filtrele(file_html)
	s = Stack.new
	balanced = true
	i = 0
	while i < (tags.length)
		tag = tags[i]
		if tag[0] != "/"
			s.push(tag)
		else
			if s.isEmpty()
				balanced = false
			else
				top = s.peek()
 
				if not matches(top, tag)
					balanced = false
				else
					top = s.pop()
				end	
			end
		end
		i += 1
	end
 
	if balanced and s.isEmpty()
		print "True" # Html dengeli
	else
		print "False" # Html dengesiz 
	end
end
 
html_tag_checker("deneme.html")
