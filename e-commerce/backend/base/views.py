from django.shortcuts import render
from django.views import View
from django.http import HttpResponse,HttpResponseRedirect
from base.models import Product,Categorie
from .forms import ProductForm,CategorieForm
# Create your views here.
class Home(View):
    def get(self,request):
        return render(request,'hello.html',{})
class ProductList(View):
    def get(self,request):
        products=Product.objects.all()
        return render(request,'listProducts.html',{'products':products})
class ProductCreate(View):
    def get(self,request):
        form = ProductForm()
        return render(request,'productCreate.html',{'form':form})
    def post(self,request):
        form = ProductForm(request.POST,request.FILES)
        if form.is_valid():
            form.save()
            return HttpResponseRedirect('/products/')
        return render(request,'productCreate.html',{'form':form})

class ProductShow(View):
        def get(self, request, pk):
            product = Product.objects.get(id=pk)
            return render(request, 'productShow.html', {'Product': product})
class ProductUpdate(View):
        def get(self,request,pk):
            product = Product.objects.get(id=pk)
            form = ProductForm(instance=product)
            return render(request,'productEdit.html',{'form':form,'product':product})
        def post(self,request,pk):
            product = Product.objects.get(id=pk)
            form = ProductForm(request.POST,request.FILES,instance=product)
            if form.is_valid():
                form.save()
                return HttpResponseRedirect('/products/')
            return render(request,'productCreate.html',{'form':form})
class ProductDelete(View):
    def get(self,request,id):
        product = Product.objects.get(id=id)
        product.delete()
        return HttpResponseRedirect('/products/')

class CategorieList(View):
    def get(self,request):
        categories=Categorie.objects.all()
        return render(request,'listCategories.html',{'categories':categories})
class CategorieCreate(View):
    def get(self,request):
        formCategorie = CategorieForm()
        return render(request,'categorieCreate.html',{'formCategorie':formCategorie})
    def post(self,request):
        formCategorie = CategorieForm(request.POST,request.FILES)
        if formCategorie.is_valid():
            formCategorie.save()
            return HttpResponseRedirect('/categories/')
        return render(request,'categorieCreate.html',{'formCategorie':formCategorie})
class CategorieShow(View):
        def get(self, request, pk):
            categorie = Categorie.objects.get(id=pk)
            return render(request, 'categorieShow.html', {'Categorie': categorie})
class CategorieUpdate(View):
        def get(self,request,pk):
            categorie = Categorie.objects.get(id=pk)
            formCategorie = CategorieForm(instance=categorie)
            return render(request,'categorieEdit.html',{'formCategorie':formCategorie,'categorie':categorie})
        def post(self,request,pk):
            categorie = Categorie.objects.get(id=pk)
            formCategorie = CategorieForm(request.POST,request.FILES,instance=categorie)
            if formCategorie.is_valid():
                formCategorie.save()
                return HttpResponseRedirect('/categories/')
            return render(request,'productCreate.html',{'form':form})
class CategorieDelete(View):
    def get(self,request,id):
        categorie = Categorie.objects.get(id=id)
        categorie.delete()
        return HttpResponseRedirect('/categories/')