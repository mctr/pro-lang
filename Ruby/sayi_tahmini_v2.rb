#!/usr/bin/ruby
# coding: utf-8

def uret() rand(100) end
hedef = uret()
puts "tahmin et?:"
begin
  tahmin = gets.to_i
  if    tahmin < hedef then puts "sayiyi buyultun"
  elsif tahmin > hedef then puts "sayiyi kucultun"
  end
end until hedef == tahmin
puts "tebrikler bildiniz!"
