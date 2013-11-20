class Stack
	def initialize
		@liste = []
	end
	def length 
		@liste.length
	end
	
	def push(item) 
		@liste.push item
		self
	end
	def isEmpty
		if @liste.length == 0
			return true
		else
			return false
		end
	end
	def peek 
		 @liste[-1]
	end
	def pop
         @liste.pop
	end
	def show
		print "Liste :", @liste
	end
end
