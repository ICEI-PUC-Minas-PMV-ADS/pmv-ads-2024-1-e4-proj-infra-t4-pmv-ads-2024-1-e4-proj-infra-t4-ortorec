import { View, Text, SafeAreaView, Image, ScrollView, SectionList, FlatList, RefreshControl, Alert } from 'react-native'
import { Link, router } from "expo-router";
import React from 'react'
import { useState, useEffect } from 'react'
import { images } from "../../constants"
import CustomButton from '@/components/CustomButton'
import useAppwrite from '../../lib/useAppwrite'
import { removeCart, showCartProducts } from '../../lib/appwrite'
import { CartProduct } from '@/components';
import { useGlobalContext } from "../../context/GlobalProvider";


const Carrinho = () => {

  const { user, setUser, setIsLogged } = useGlobalContext();

  const userId = user.$id;

  const [refreshing, setRefreshing] = useState(false)

  const { data: compras, refetch } = useAppwrite(
    () => showCartProducts(userId));

    const onRefresh = async () => {
      setRefreshing(true);
      await refetch();
      setRefreshing(false);
    }


  return (
    <SafeAreaView className='h-full '>
      <FlatList
        data={compras}
        keyExtractor={(item) => item.$id}
        renderItem={({ item }) => (
          <CartProduct 
          nome={item.nome}
          preco={item.preco}/>
        )}
        ListHeaderComponent={( ) => (
        <View className='mt-20 mb-10 px-8 space-y-6'>
          <View className="justify-between items-center flex-row mb-6">

            <View>
              <Text className="text-2xl font-psemibold">
                Carrinho
              </Text>
            </View>

            <View className="mt-1.5">
              <Image
                source={images.recomecarLogoPequeno}
                className="w-20 h-20"
                resizeMode="contain"
              />
            </View>

          </View>

          <View className='border-2 rounded-xl border-secondary-200'>

            <View className='flex-row justify-between p-5 bg-secondary-200 rounded-lg'>
              <Text className='text-xl text-white font-psemibold'>Produto</Text>
              <Text className='text-xl text-white font-psemibold'>Valor</Text>
            </View>

          </View>

        </View>
        )}
        ListFooterComponent={( ) => (
          <CustomButton
            title="Finalizar Compra"
            containerStyles='p-2 mt-10 w-[90%] items-center justify-center  rounded-xl mx-auto mb-10'
            textStyles='text-xl'
            handlePress={() => {
              Alert.alert('Finalizar Compra?', 'Deseja finalizar a compra?', [
                {
                  text: 'Cancelar',
                  onPress: () => console.log('Cancel Pressed'),
                  style: 'cancel'
                },
                {
                  text: 'Finalizar',
                  // onPress: () => removeCart()
                }
              ])
            }}
          />
        )}
        refreshControl={<RefreshControl refreshing={refreshing} onRefresh={onRefresh} />}
      />
    </SafeAreaView>
  )
}

export default Carrinho