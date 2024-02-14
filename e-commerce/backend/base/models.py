from email.mime import image
from unittest.util import _MAX_LENGTH
from django.db import models
from django.contrib.auth.models import User

# Create your models here.

class Product(models.Model):
    user=models.ForeignKey(User,on_delete=models.SET_NULL,null=True)
    name=models.CharField(max_length=200,null=True,blank=True)
    image=models.ImageField(null=True,blank=True)
    category=models.CharField(max_length=200,null=True,blank=True)
    price=models.DecimalField(max_digits=7,decimal_places=2,null=True,blank=True)
    createAt=models.DateTimeField(auto_now_add=True)
class Categorie(models.Model):
    nom=models.CharField(max_length=200,null=True,blank=True)
def __str__(self):
    return self.name
