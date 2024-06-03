import { View, Text, FlatList, Image, RefreshControl, Alert} from 'react-native'
import { useEffect, useState } from 'react'
import React from 'react'
import { SafeAreaView } from 'react-native-safe-area-context'

import { images } from "../../constants"
import SearchImput from "../../components/SearchImput"
import Destaques from "../../components/Destaques"
import EstadoVazio from '@/components/EstadoVazio'
import { getAllPosts } from '../../lib/appwrite'
import useAppwrite from '../../lib/useAppwrite'
import ProductCard from '../../components/ProductCard'

const Home = () => {

  const { data: posts, refetch } = useAppwrite(getAllPosts);

  const [refreshing, setRefreshing] = useState(false)

  const onRefresh = async () => {
    setRefreshing(true);
    await refetch();
    setRefreshing(false);
  }

  console.log(posts)

  return (
    <SafeAreaView className='h-full'>
      <FlatList
        data={posts}
        keyExtractor={(item) => item.$id}
        renderItem={({ item }) => (
          <ProductCard product={item}/>
        )}
        ListHeaderComponent={( ) => (
          <View className="my-6 px-4 space-y-6">

            <View className="justify-between items-start flex-row mb-6">

              <View>
                <Text className="font-pmedium text-sm text-secondary">
                  Bem-Vindo de volta!
                </Text>
                <Text className="text-2xl font-psemibold">
                  Usuário
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

            <SearchImput/>

            <View className='w-full flex-1 pt-5 pb-8'>
              <Text className='text-secondary text-lg font-pregular mb-3'>
                Produtos em Destaque
              </Text>

              <Destaques posts={[{ id: 1}, { id: 2 }, { id: 3}] ?? []} />
            </View>

          </View>
        )}

        ListEmptyComponent={( ) => (
          <EstadoVazio
            title="Nenhum produto encontrado"
          />
        )}

        refreshControl={<RefreshControl refreshing={refreshing} onRefresh={onRefresh} />}
      />
    </SafeAreaView>
  )
}

export default Home