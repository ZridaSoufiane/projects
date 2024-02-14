from django.urls import path
from . import views

urlpatterns = [
    path('',views.Home.as_view(),name='Home'),
    path('products/',views.ProductList.as_view(),name='Products'),
    path('/products/create',views.ProductCreate.as_view(),name='productCreate'),
    path('product/update/<str:pk>',views.ProductUpdate.as_view(),name="productUpdate"),
    path('product/show/<str:pk>', views.ProductShow.as_view(), name="productShow"),
    path('product/delete/<str:id>', views.ProductDelete.as_view(), name="productDelete"),
    path('categories/',views.CategorieList.as_view(),name='Categories'),
    path('/categories/create',views.CategorieCreate.as_view(),name='categorieCreate'),
    path('categories/update/<str:pk>',views.CategorieUpdate.as_view(),name="categorieUpdate"),
    path('categories/show/<str:pk>', views.CategorieShow.as_view(), name="categorieShow"),
    path('categories/delete/<str:id>', views.CategorieDelete.as_view(), name="categorieDelete")

]