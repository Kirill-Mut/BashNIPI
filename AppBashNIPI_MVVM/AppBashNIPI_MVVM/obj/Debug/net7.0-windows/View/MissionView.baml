   M S B A M L   `   `   `  ����K  GAppBashNIPI_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:AppBashNIPIMVVM.ViewAppBashNIPIMVVM.View  5   	   E'clr-namespace:AppBashNIPIMVVM.ViewModelAppBashNIPIMVVM.ViewModel  5   	   ?$clr-namespace:AppBashNIPI_MVVM.ModelAppBashNIPI_MVVM.Model  5   	   &     AppBashNIPIMVVM.View.MissionView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   4local"clr-namespace:AppBashNIPIMVVM.View     5   	   =	viewModel'clr-namespace:AppBashNIPIMVVM.ViewModel     5   	   :	dataTypes$clr-namespace:AppBashNIPI_MVVM.Model     5   	     � Title$  Задача��5
   	   $	��450��6   $	��800��6%   .��5      �  � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��3* �6   .+�5   
   �� $ ��Идентификатор��6   $
��Left=�6(   $	��Top=�6C   $��0,0,0,0q�6[   �� 5   
   $��Наименования��6   $
��Left=�6'   $	��Top=�6B   $��0,30,0,0q�6Z   �� 5   
   $��Состояние��6   $
��Left=�6$   $	��Top=�6?   $��0,60,0,0q�6W   �� 5   
   $��1��6   $	��Top=�5      $��0,5,10,0q�5      ��5      �� *Id+ �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5   
   $��1��6   $	��Top=�5      $��	0,34,10,0q�5      ��5      �� *Name+$ PropertyChanged=�5      �� 5   
   $��1��6   $	��Top=�5       $��	0,64,10,0q�5!      ��5      ��  �� Source 7   1AppBashNIPI_MVVM.Model.EnumBindingSourceExtension  *M� *dataTypes:EnumStatus++ �� SelectedItem 5      �� *Status+ �� Mode$ TwoWay=�5!      �� 5"   
   $��2��6    �� TextWrapping$
 Wrap=�5$      $��Stretch=�5%      $��0,90,0,0q�5&      ��5#      �� *Body+$ PropertyChanged=�5&      5'      5(      